# dstcertfix
On September 30th, 2021 the **DST Root CA X3** certificate expired causing many devices displaying an invalid certificate error, including websites and services using the [Let's Encrypt](https://letsencrypt.org/) certificates.
Older devices that don't receive support from their manufacturer or have disabled their updates may expirience this issue and won't have an effective and fast way to mitigate this error.

![enter image description here](https://kinsta.com/wp-content/uploads/2020/07/NET-ERR_CERT_AUTHORITY_INVALID-error-in-chrome-1.png)

## What is dstcertfix?
The **dstcertfix** application allows the user to automatically remove the old / expired certificate and install the new one. This enables non-technical users (even tech savvy ones that are simply bored to deal with this) to mitigate the error without having them to dig through all the steps required to do so.

## Usage

 1. Close all open browsers (Google Chrome, Mozilla Firefox, etc.)
 2. Launch dstcertfix.exe
 3. Select which user account you would like to fix. You can choose between your current user account or all users in your computer (Local Machine)
 4. Click the Fix button

That's it!

## FAQs

**Why do I have to close all browsers before launching the app?**

Some browsers keep the certificates in a cached state  and this might result in you still keep seeing the invalid certificate error even after you apply the fix. So it's better to close your browsers before applying the fix.

**Does this application require administrative privillages?**

If you want to apply the fix only for your user account then no. If you want to apply the fix to all the accounts in your computer then yes. This is not an application limitation but a requirement from Windows.

**Do you support multiple languages?** 

At the moment only Greek and English are supported. If you want another language to be added you can [contact me](mailto:me@giannisftaras.dev) or submit a pull request.

**I still keep getting the same error even after I apply the fix. What should I do?**

 - Make sure you have closed all browsers before applying the fix, even if your browser name is not mentioned above
 - Restart your computer and check if the issue persists

If you keep getting errors even after following the above recommendations you can try applying the fix manunally [using this guide](https://techglimpse.com/dst-root-ca-x3-expired-certificate-error/) or consult a computer technician since the error you are seeing might not be related.

**Where can I just download the new certificate?**
You can download it directly from the Let's Encrypt server here: https://letsencrypt.org/certs/isrgrootx1.der

## Compatibility ##
Tested on:

 - Windows 7 x86 (32 bit)
 - Windows 7 x64 (64 bit)
 - Windows 10 x86 (32 bit)
 - Windows 10 x64 (64 bit)

Operating system editions (Home, Professional, etc.) should not pose an issue. If you encounter a problem create an issue on Github or [contact me](mailto:me@giannisftaras.dev).

## Honorable mentions ##
If you want to apply the fix manually you can [follow this guide](https://techglimpse.com/dst-root-ca-x3-expired-certificate-error/). This is the same guide I used the first time I fixed the issue and helped me to safely download the new certificate.

The application uses icons from [Flaticon](https://www.flaticon.com/):

 - [Application icon by FreePik](https://www.flaticon.com/premium-icon/certification_3227027)
 - [Language selection icon by Freepik](https://www.flaticon.com/premium-icon/translation_2014826)
 - [US flag icon by Freepik](https://www.flaticon.com/free-icon/united-states_197484)
 - [Greek flag icon by Freepik](https://www.flaticon.com/free-icon/greece_197566)

## Changelog ##
v1.0.0 (22/11/2021) - Initial release

## Checksums ##
v1.0.0 
 1. MD5: -
 2. SHA1: -
 3. SHA256: -

## Licence ##
The application is open source and published under the Apache 2.0 licence. You can take it, use it, copy it, change the code and do whatever you like.
