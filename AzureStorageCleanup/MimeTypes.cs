using System.Collections.Generic;

namespace AzureStorageCleanup
{
	public class MimeTypes
	{
		private static readonly Dictionary<string, string> _extensionMap = new Dictionary<string, string>();

		static MimeTypes()
		{
			_extensionMap.Add(".323", "text/h323");
			_extensionMap.Add(".asx", "video/x-ms-asf");
			_extensionMap.Add(".acx", "application/internet-property-stream");
			_extensionMap.Add(".ai", "application/postscript");
			_extensionMap.Add(".aif", "audio/x-aiff");
			_extensionMap.Add(".aiff", "audio/aiff");
			_extensionMap.Add(".axs", "application/olescript");
			_extensionMap.Add(".aifc", "audio/aiff");
			_extensionMap.Add(".asr", "video/x-ms-asf");
			_extensionMap.Add(".avi", "video/x-msvideo");
			_extensionMap.Add(".asf", "video/x-ms-asf");
			_extensionMap.Add(".au", "audio/basic");
			_extensionMap.Add(".application", "application/x-ms-application");
			_extensionMap.Add(".bin", "application/octet-stream");
			_extensionMap.Add(".bas", "text/plain");
			_extensionMap.Add(".bcpio", "application/x-bcpio");
			_extensionMap.Add(".bmp", "image/bmp");
			_extensionMap.Add(".cdf", "application/x-cdf");
			_extensionMap.Add(".cat", "application/vndms-pkiseccat");
			_extensionMap.Add(".crt", "application/x-x509-ca-cert");
			_extensionMap.Add(".c", "text/plain");
			_extensionMap.Add(".css", "text/css");
			_extensionMap.Add(".cer", "application/x-x509-ca-cert");
			_extensionMap.Add(".crl", "application/pkix-crl");
			_extensionMap.Add(".cmx", "image/x-cmx");
			_extensionMap.Add(".csh", "application/x-csh");
			_extensionMap.Add(".cod", "image/cis-cod");
			_extensionMap.Add(".cpio", "application/x-cpio");
			_extensionMap.Add(".clp", "application/x-msclip");
			_extensionMap.Add(".crd", "application/x-mscardfile");
			_extensionMap.Add(".deploy", "application/octet-stream");
			_extensionMap.Add(".dll", "application/x-msdownload");
			_extensionMap.Add(".dot", "application/msword");
			_extensionMap.Add(".doc", "application/msword");
			_extensionMap.Add(".dvi", "application/x-dvi");
			_extensionMap.Add(".dir", "application/x-director");
			_extensionMap.Add(".dxr", "application/x-director");
			_extensionMap.Add(".der", "application/x-x509-ca-cert");
			_extensionMap.Add(".dib", "image/bmp");
			_extensionMap.Add(".dcr", "application/x-director");
			_extensionMap.Add(".disco", "text/xml");
			_extensionMap.Add(".exe", "application/octet-stream");
			_extensionMap.Add(".etx", "text/x-setext");
			_extensionMap.Add(".evy", "application/envoy");
			_extensionMap.Add(".eml", "message/rfc822");
			_extensionMap.Add(".eps", "application/postscript");
			_extensionMap.Add(".flr", "x-world/x-vrml");
			_extensionMap.Add(".fif", "application/fractals");
			_extensionMap.Add(".gtar", "application/x-gtar");
			_extensionMap.Add(".gif", "image/gif");
			_extensionMap.Add(".gz", "application/x-gzip");
			_extensionMap.Add(".hta", "application/hta");
			_extensionMap.Add(".htc", "text/x-component");
			_extensionMap.Add(".htt", "text/webviewhtml");
			_extensionMap.Add(".h", "text/plain");
			_extensionMap.Add(".hdf", "application/x-hdf");
			_extensionMap.Add(".hlp", "application/winhlp");
			_extensionMap.Add(".html", "text/html");
			_extensionMap.Add(".htm", "text/html");
			_extensionMap.Add(".hqx", "application/mac-binhex40");
			_extensionMap.Add(".isp", "application/x-internet-signup");
			_extensionMap.Add(".iii", "application/x-iphone");
			_extensionMap.Add(".ief", "image/ief");
			_extensionMap.Add(".ivf", "video/x-ivf");
			_extensionMap.Add(".ins", "application/x-internet-signup");
			_extensionMap.Add(".ico", "image/x-icon");
			_extensionMap.Add(".jfif", "image/pjpeg");
			_extensionMap.Add(".jpe", "image/jpeg");
			_extensionMap.Add(".jpeg", "image/jpeg");
			_extensionMap.Add(".jpg", "image/jpeg");
			_extensionMap.Add(".js", "application/x-javascript");
			_extensionMap.Add(".lsx", "video/x-la-asf");
			_extensionMap.Add(".latex", "application/x-latex");
			_extensionMap.Add(".lsf", "video/x-la-asf");
			_extensionMap.Add(".manifest", "application/x-ms-manifest");
			_extensionMap.Add(".mhtml", "message/rfc822");
			_extensionMap.Add(".mny", "application/x-msmoney");
			_extensionMap.Add(".mht", "message/rfc822");
			_extensionMap.Add(".mid", "audio/mid");
			_extensionMap.Add(".mpv2", "video/mpeg");
			_extensionMap.Add(".man", "application/x-troff-man");
			_extensionMap.Add(".mvb", "application/x-msmediaview");
			_extensionMap.Add(".mpeg", "video/mpeg");
			_extensionMap.Add(".m3u", "audio/x-mpegurl");
			_extensionMap.Add(".mdb", "application/x-msaccess");
			_extensionMap.Add(".mpp", "application/vnd.ms-project");
			_extensionMap.Add(".m1v", "video/mpeg");
			_extensionMap.Add(".mpa", "video/mpeg");
			_extensionMap.Add(".me", "application/x-troff-me");
			_extensionMap.Add(".m13", "application/x-msmediaview");
			_extensionMap.Add(".movie", "video/x-sgi-movie");
			_extensionMap.Add(".m14", "application/x-msmediaview");
			_extensionMap.Add(".mpe", "video/mpeg");
			_extensionMap.Add(".mp2", "video/mpeg");
			_extensionMap.Add(".mov", "video/quicktime");
			_extensionMap.Add(".mp3", "audio/mpeg");
			_extensionMap.Add(".mpg", "video/mpeg");
			_extensionMap.Add(".ms", "application/x-troff-ms");
			_extensionMap.Add(".nc", "application/x-netcdf");
			_extensionMap.Add(".nws", "message/rfc822");
			_extensionMap.Add(".oda", "application/oda");
			_extensionMap.Add(".ods", "application/oleobject");
			_extensionMap.Add(".pmc", "application/x-perfmon");
			_extensionMap.Add(".p7r", "application/x-pkcs7-certreqresp");
			_extensionMap.Add(".p7b", "application/x-pkcs7-certificates");
			_extensionMap.Add(".p7s", "application/pkcs7-signature");
			_extensionMap.Add(".pmw", "application/x-perfmon");
			_extensionMap.Add(".ps", "application/postscript");
			_extensionMap.Add(".p7c", "application/pkcs7-mime");
			_extensionMap.Add(".pbm", "image/x-portable-bitmap");
			_extensionMap.Add(".png", "image/png");
			_extensionMap.Add(".ppm", "image/x-portable-pixmap");
			_extensionMap.Add(".pub", "application/x-mspublisher");
			_extensionMap.Add(".pnm", "image/x-portable-anymap");
			_extensionMap.Add(".pml", "application/x-perfmon");
			_extensionMap.Add(".p10", "application/pkcs10");
			_extensionMap.Add(".pfx", "application/x-pkcs12");
			_extensionMap.Add(".p12", "application/x-pkcs12");
			_extensionMap.Add(".pdf", "application/pdf");
			_extensionMap.Add(".pps", "application/vnd.ms-powerpoint");
			_extensionMap.Add(".p7m", "application/pkcs7-mime");
			_extensionMap.Add(".pko", "application/vndms-pkipko");
			_extensionMap.Add(".ppt", "application/vnd.ms-powerpoint");
			_extensionMap.Add(".pmr", "application/x-perfmon");
			_extensionMap.Add(".pma", "application/x-perfmon");
			_extensionMap.Add(".pot", "application/vnd.ms-powerpoint");
			_extensionMap.Add(".prf", "application/pics-rules");
			_extensionMap.Add(".pgm", "image/x-portable-graymap");
			_extensionMap.Add(".qt", "video/quicktime");
			_extensionMap.Add(".ra", "audio/x-pn-realaudio");
			_extensionMap.Add(".rgb", "image/x-rgb");
			_extensionMap.Add(".ram", "audio/x-pn-realaudio");
			_extensionMap.Add(".rmi", "audio/mid");
			_extensionMap.Add(".ras", "image/x-cmu-raster");
			_extensionMap.Add(".roff", "application/x-troff");
			_extensionMap.Add(".rtf", "application/rtf");
			_extensionMap.Add(".rtx", "text/richtext");
			_extensionMap.Add(".sv4crc", "application/x-sv4crc");
			_extensionMap.Add(".spc", "application/x-pkcs7-certificates");
			_extensionMap.Add(".setreg", "application/set-registration-initiation");
			_extensionMap.Add(".snd", "audio/basic");
			_extensionMap.Add(".stl", "application/vndms-pkistl");
			_extensionMap.Add(".setpay", "application/set-payment-initiation");
			_extensionMap.Add(".stm", "text/html");
			_extensionMap.Add(".shar", "application/x-shar");
			_extensionMap.Add(".sh", "application/x-sh");
			_extensionMap.Add(".sit", "application/x-stuffit");
			_extensionMap.Add(".spl", "application/futuresplash");
			_extensionMap.Add(".sct", "text/scriptlet");
			_extensionMap.Add(".scd", "application/x-msschedule");
			_extensionMap.Add(".sst", "application/vndms-pkicertstore");
			_extensionMap.Add(".src", "application/x-wais-source");
			_extensionMap.Add(".sv4cpio", "application/x-sv4cpio");
			_extensionMap.Add(".swf", "application/x-shockwave-flash");
			_extensionMap.Add(".tex", "application/x-tex");
			_extensionMap.Add(".tgz", "application/x-compressed");
			_extensionMap.Add(".t", "application/x-troff");
			_extensionMap.Add(".tar", "application/x-tar");
			_extensionMap.Add(".tr", "application/x-troff");
			_extensionMap.Add(".tif", "image/tiff");
			_extensionMap.Add(".txt", "text/plain");
			_extensionMap.Add(".texinfo", "application/x-texinfo");
			_extensionMap.Add(".trm", "application/x-msterminal");
			_extensionMap.Add(".tiff", "image/tiff");
			_extensionMap.Add(".tcl", "application/x-tcl");
			_extensionMap.Add(".texi", "application/x-texinfo");
			_extensionMap.Add(".tsv", "text/tab-separated-values");
			_extensionMap.Add(".ustar", "application/x-ustar");
			_extensionMap.Add(".uls", "text/iuls");
			_extensionMap.Add(".vcf", "text/x-vcard");
			_extensionMap.Add(".wps", "application/vnd.ms-works");
			_extensionMap.Add(".wav", "audio/wav");
			_extensionMap.Add(".wrz", "x-world/x-vrml");
			_extensionMap.Add(".wri", "application/x-mswrite");
			_extensionMap.Add(".wks", "application/vnd.ms-works");
			_extensionMap.Add(".wmf", "application/x-msmetafile");
			_extensionMap.Add(".wcm", "application/vnd.ms-works");
			_extensionMap.Add(".wrl", "x-world/x-vrml");
			_extensionMap.Add(".wdb", "application/vnd.ms-works");
			_extensionMap.Add(".wsdl", "text/xml");
			_extensionMap.Add(".xml", "text/xml");
			_extensionMap.Add(".xlm", "application/vnd.ms-excel");
			_extensionMap.Add(".xaf", "x-world/x-vrml");
			_extensionMap.Add(".xla", "application/vnd.ms-excel");
			_extensionMap.Add(".xls", "application/vnd.ms-excel");
			_extensionMap.Add(".xof", "x-world/x-vrml");
			_extensionMap.Add(".xlt", "application/vnd.ms-excel");
			_extensionMap.Add(".xlc", "application/vnd.ms-excel");
			_extensionMap.Add(".xsl", "text/xml");
			_extensionMap.Add(".xbm", "image/x-xbitmap");
			_extensionMap.Add(".xlw", "application/vnd.ms-excel");
			_extensionMap.Add(".xpm", "image/x-xpixmap");
			_extensionMap.Add(".xwd", "image/x-xwindowdump");
			_extensionMap.Add(".xsd", "text/xml");
			_extensionMap.Add(".z", "application/x-compress");
			_extensionMap.Add(".zip", "application/x-zip-compressed");
			_extensionMap.Add(".*", "application/octet-stream");
		}

		public static string GetMimeType(string fileExtension)
		{
			return MimeTypes.GetMimeMapping(fileExtension);
		}

		private static string GetMimeMapping(string fileExtension)
		{
			if (string.IsNullOrEmpty(fileExtension))
				return _extensionMap[".*"];

			fileExtension = fileExtension.ToLower();

			if (_extensionMap.ContainsKey(fileExtension))
				return _extensionMap[fileExtension];
			else
				return _extensionMap[".*"];
		}
	}
}