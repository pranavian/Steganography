# Steganography

##Functionality:
- Accepts JPEG file and alters hex values to hide text data incl. white space, comma, full stop.
- Opens stego-medium JPEG file and reads hidden text from hex bytes

##Future Work:
- Accept JPEG file and alters hex values to hide image data
- Opens stego-medium JPEG file and reads hidden image from hex bytes
- Opens Exif data from JPEG/exif file and displays values stored in a list
- Encrypt text to be hidden inside of image

##Known Issues:
- Visible pixel changes on images (Possible issue with Restart markers?)


##Technical Details:
- Language Used: C#
- External Dependencies: None
