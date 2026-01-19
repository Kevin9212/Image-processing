#pragma once
#include <opencv2/opencv.hpp>
using namespace cv;
//¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K¡K
#ifdef IMGFUNC_EXPORTS
#define IMGFUNC_API extern "C" __declspec(dllexport)
#else
#define IMGFUNC_API extern "C" __declspec(dllimport)
#endif
struct ImageOptions {
    double rotateAngle;
    int ReflectY;
    int ReflectX;
    int Thresholding;
    int GrayScale;
    double ShearX;
    double ShearY;
    int PepperNoisePercent;
    int k_size;
    int Histogram;
    int CannyLow;
    int CannyHigh;
};
IMGFUNC_API void showImage(char* filename,  ImageOptions& options);
IMGFUNC_API void rotateImage(Mat& srcImg, double angle);
IMGFUNC_API void ReflectY(Mat& srcImg);
IMGFUNC_API void ReflectX(Mat& srcImg);
IMGFUNC_API void ThresholdingImage(Mat& srcImg);
IMGFUNC_API void GrayScaleImage(Mat& srcImg);
IMGFUNC_API void ShearX(Mat& srcImg, double Sh);
IMGFUNC_API void ShearY(Mat& srcImg, double Sh);
IMGFUNC_API void PepperNoise(Mat& srcImg, int percent);
IMGFUNC_API void medianBlurImage(Mat& srcImg, int k_size);
IMGFUNC_API void HSVHistogramImage(Mat& srcImg);
IMGFUNC_API void GrayScaleHistogramImage(Mat& srcImg);
IMGFUNC_API void CannyImage(Mat& srcImg,int low,int high);
