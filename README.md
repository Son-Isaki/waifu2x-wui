# waifu2x-wui
![waifu2x-wui](https://img.shields.io/badge/1.0.0-waifu2x--wui-orange)
![support windows x64](https://img.shields.io/badge/support-windows%20x64-green)
![waifu2x](https://img.shields.io/badge/image--processor-waifu2x-green)

waifu2x-wui is a windows application that allows you upscale and post-process images in one go.

I needed to export files in differents formats like Adobe does it with the powerful [waifu2x](https://waifu2x.udp.jp/) image processor.
So I created a useful interface to speed up my workflow and decided to share it.

## Features

* Multiple exports configuration
* Configuration save in a profile file
* The power of waifu2x

## TODO

* Run the export process in background
* Add multiple file input / folder inputs ?
* Logs in popup ?
* Gui support for other languages ?

## Developpers

The app is running using [waiffu2x-caffe](https://github.com/lltcggie/waifu2x-caffe) to generate the images.
You'll have to copy the content of the built app inside the **Resources** directory.
