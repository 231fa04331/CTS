using System.Net;

string input =
"<script>alert('hack')</script>";

string safe =
WebUtility.HtmlEncode(input);

Console.WriteLine(safe);