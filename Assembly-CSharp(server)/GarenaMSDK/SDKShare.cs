using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BFF RID: 11263
	[Token(Token = "0x2002BFF")]
	public static class SDKShare
	{
		// Token: 0x0600F92F RID: 63791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F92F")]
		[Address(RVA = "0x273F9C4", Offset = "0x273F9C4", VA = "0x7BBCF3F9C4")]
		public static void SendGameToSession(int scene, string title, string description, string mediaTag, string caption, string url, string imagePath, int compressRate)
		{
		}

		// Token: 0x0600F930 RID: 63792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F930")]
		[Address(RVA = "0x273FDF8", Offset = "0x273FDF8", VA = "0x7BBCF3FDF8")]
		public static void SendMediaToSession(int scene, string mediaTag, string messageExt, string imagePath)
		{
		}

		// Token: 0x0600F931 RID: 63793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F931")]
		[Address(RVA = "0x27400A0", Offset = "0x27400A0", VA = "0x7BBCF400A0")]
		public static void SendLinkToSession(int scene, string mediaTag, string url, string title, string caption, string description, string mediaUrl)
		{
		}

		// Token: 0x0600F932 RID: 63794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F932")]
		[Address(RVA = "0x2740454", Offset = "0x2740454", VA = "0x7BBCF40454")]
		public static void ShareToFacebook(int scene, string name, string caption, string description, string link, string imagePath, int compressRate, string mediaUrl)
		{
		}

		// Token: 0x0600F933 RID: 63795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F933")]
		[Address(RVA = "0x2740804", Offset = "0x2740804", VA = "0x7BBCF40804")]
		public static void SendLinkToFacebook(string name, string caption, string description, string link, string mediaUrl)
		{
		}

		// Token: 0x0600F934 RID: 63796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F934")]
		[Address(RVA = "0x2740ADC", Offset = "0x2740ADC", VA = "0x7BBCF40ADC")]
		public static void SendRequestInvitationToFacebook(string title, string message)
		{
		}

		// Token: 0x0600F935 RID: 63797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F935")]
		[Address(RVA = "0x2740CA0", Offset = "0x2740CA0", VA = "0x7BBCF40CA0")]
		public static void SendLinkToVKontakte(string message, string url)
		{
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F936")]
		[Address(RVA = "0x2740F3C", Offset = "0x2740F3C", VA = "0x7BBCF40F3C")]
		public static void ShareToVKontakte(string message, string url, string imagePath, int compressRate)
		{
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F937")]
		[Address(RVA = "0x2740FC8", Offset = "0x2740FC8", VA = "0x7BBCF40FC8")]
		public static void SendGameRequestToFacebookUser(long fbUid, string title, string message, string data, [Optional] Action<int, string, long> callback)
		{
		}

		// Token: 0x04011CD2 RID: 72914
		[Token(Token = "0x4011CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Action<int, string, long> _SendGameRequestToFacebookUserCallback;

		// Token: 0x04011CD3 RID: 72915
		[Token(Token = "0x4011CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static long _CallBackFBUid;

		// Token: 0x02002C00 RID: 11264
		[Token(Token = "0x2002C00")]
		public enum ShareScene
		{
			// Token: 0x04011CD5 RID: 72917
			[Token(Token = "0x4011CD5")]
			Chat,
			// Token: 0x04011CD6 RID: 72918
			[Token(Token = "0x4011CD6")]
			Buzz
		}
	}
}
