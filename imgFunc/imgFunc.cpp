#include "pch.h"
#include "imgFunc.h"
#include <opencv2/opencv.hpp>
#define PI 3.14159
using namespace cv;
// This is an example of an exported function.
IMGFUNC_API void showImage(char* filename, ImageOptions& options)
{
	Mat src;
	src = imread(filename, IMREAD_REDUCED_COLOR_2);
	if (src.data) {
		
		
		rotateImage(src, options.rotateAngle);
		if (options.ReflectY) {
			ReflectY(src);
		}
		if (options.ReflectX) {

			ReflectX(src);
		}
		if (options.GrayScale) {
			GrayScaleImage(src);
		}
		if (options.Thresholding) {
			ThresholdingImage(src);
		}
		
		ShearX(src, options.ShearX);
		if (options.ShearY) {
			ShearY(src, options.ShearY);
		}
		PepperNoise(src, options.PepperNoisePercent);
		if (options.k_size) {
			medianBlur(src, src, options.k_size);
		}
		if (options.Histogram) {
			if (options.GrayScale) {
				GrayScaleHistogramImage(src);
			}
			else {
				HSVHistogramImage(src);
			}
		}
		if (options.CannyLow && options.CannyHigh) 
		{
			CannyImage(src , options.CannyLow,options.CannyLow);
		}
		imshow("Image", src);
		waitKey(0);
	}
}
IMGFUNC_API void rotateImage(Mat& srcImg, double angle)
{
	double rad = angle * PI / 180;
	Point2d center(srcImg.cols / 2., srcImg.rows / 2.);
	Point2d rotCenter(center.x * cos(rad) - center.y * sin(rad),
		center.x * sin(rad) + center.y * cos(rad));
	Point2d newCenter(center * 2);
	Point2d disp(newCenter - rotCenter);
	Mat M1 = (Mat_<double>(2, 3) << cos(rad), -sin(rad), disp.x,
		sin(rad), cos(rad), disp.y);
	warpAffine(srcImg,srcImg, M1, srcImg.size() * 2, INTER_CUBIC);

}	
IMGFUNC_API void ReflectX(Mat& srcImg) {
	Mat M = (Mat_<double>(2, 3) << -1, 0, srcImg.cols, 0, 1, 0);
	warpAffine(srcImg, srcImg, M, srcImg.size() * 2, INTER_CUBIC);
}
IMGFUNC_API void ReflectY(Mat& srcImg) {
	Mat M = (Mat_<double>(2, 3) << 1, 0, 0, 0, -1, srcImg.rows);
	warpAffine(srcImg, srcImg, M, srcImg.size() * 2, INTER_CUBIC);
}
IMGFUNC_API void ThresholdingImage(Mat& srcImg) {
	int r, c, ch, channels = srcImg.channels();
	Mat dst = srcImg.clone();
	threshold(srcImg, dst, 128, 255, THRESH_BINARY);
	srcImg = dst;
}
IMGFUNC_API void GrayScaleImage(Mat& srcImg) {
	Mat dst = srcImg.clone();
	cvtColor(srcImg, dst, COLOR_BGR2GRAY);
	srcImg = dst;
}
IMGFUNC_API void ShearX(Mat& srcImg, double Sh) {
	double offset_x = (Sh < 0) ? -Sh * srcImg.rows : 0;
	Mat M = (Mat_<double>(2, 3) << 1, Sh, offset_x, 0, 1, 0);
	Size newSize(srcImg.cols + abs(Sh * srcImg.rows) , srcImg.rows);
	warpAffine(srcImg, srcImg, M, newSize, INTER_CUBIC);
}
IMGFUNC_API void ShearY(Mat& srcImg, double Sh) {
	double offset_y = (Sh < 0) ? -Sh * srcImg.cols : 0;
	Mat M = (Mat_<double>(2, 3) << 1, 0, 0, Sh, 1, offset_y-300);
	Size newSize(srcImg.cols, srcImg.rows + abs(Sh * srcImg.cols));
	warpAffine(srcImg, srcImg, M, newSize, INTER_CUBIC);
}
IMGFUNC_API void PepperNoise(Mat& srcImg, int percent) {
	Mat randMtx = Mat::zeros(srcImg.size(), CV_8U);
	randu(randMtx, 0, 255);
	Mat pepperMask = randMtx < 2.55 * percent; //Generate the mask of pepper noice
	Mat saltMask = randMtx > 255 - 2.55 * percent; //Generate the mask of salt noice
	//Add the pepper and salt noise to image
	Mat dst = srcImg.clone();
	dst.setTo(255, saltMask); //Add salt noice
	dst.setTo(0, pepperMask); //Add pepper noice
	//Show results
	srcImg = dst;
}
IMGFUNC_API void medianBlurImage(Mat& srcImg,int k_size) {
	medianBlur(srcImg, srcImg, k_size);
}
IMGFUNC_API void HSVHistogramImage(Mat& srcImg) {
	Mat dst, Channels[3];
	//Histogram equalization
	cvtColor(srcImg, dst, COLOR_BGR2HSV);
	split(dst, Channels); // split color channels
	equalizeHist(Channels[2], Channels[2]); //Proces V channel only
	merge(Channels, 3, dst);
	cvtColor(dst, dst, COLOR_HSV2BGR);
	srcImg = dst;
}
IMGFUNC_API void GrayScaleHistogramImage(Mat& srcImg) {
	equalizeHist(srcImg, srcImg);
}
IMGFUNC_API void CannyImage(Mat& srcImg,int low,int high) {
	Mat edge, dst;
	//Retrieve edge mask using canny method
	Canny(srcImg, edge, low, high);
	srcImg.copyTo(dst, edge);
	srcImg = edge;
}