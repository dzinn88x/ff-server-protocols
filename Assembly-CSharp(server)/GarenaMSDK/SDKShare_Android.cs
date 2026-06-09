using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK
{
	// Token: 0x02002C01 RID: 11265
	[Token(Token = "0x2002C01")]
	public static class SDKShare_Android
	{
		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x0600F938 RID: 63800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001220")]
		private static AndroidJavaClass Share
		{
			[Token(Token = "0x600F938")]
			[Address(RVA = "0x2741294", Offset = "0x2741294", VA = "0x7BBCF41294")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F939 RID: 63801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F939")]
		[Address(RVA = "0x273FA80", Offset = "0x273FA80", VA = "0x7BBCF3FA80")]
		public static void SendGameToSession(int scene, string title, string description, string mediaTag, string caption, string url, string imagePath, int compressRate)
		{
		}

		// Token: 0x0600F93A RID: 63802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93A")]
		[Address(RVA = "0x273FE84", Offset = "0x273FE84", VA = "0x7BBCF3FE84")]
		public static void SendMediaToSession(int scene, string mediaTag, string messageExt, string imagePath)
		{
		}

		// Token: 0x0600F93B RID: 63803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93B")]
		[Address(RVA = "0x274014C", Offset = "0x274014C", VA = "0x7BBCF4014C")]
		public static void SendLinkToSession(int scene, string mediaTag, string url, string title, string caption, string description, string mediaUrl)
		{
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93C")]
		[Address(RVA = "0x2740500", Offset = "0x2740500", VA = "0x7BBCF40500")]
		public static void ShareToFacebook(int scene, string name, string caption, string description, string link, string imagePath, int compressRate, string mediaUrl)
		{
		}

		// Token: 0x0600F93D RID: 63805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93D")]
		[Address(RVA = "0x2740898", Offset = "0x2740898", VA = "0x7BBCF40898")]
		public static void SendLinkToFacebook(string name, string caption, string description, string link, string mediaUrl)
		{
		}

		// Token: 0x0600F93E RID: 63806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93E")]
		[Address(RVA = "0x2740B50", Offset = "0x2740B50", VA = "0x7BBCF40B50")]
		public static void SendRequestInvitationToFacebook(string title, string message)
		{
		}

		// Token: 0x0600F93F RID: 63807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F93F")]
		[Address(RVA = "0x2741078", Offset = "0x2741078", VA = "0x7BBCF41078")]
		public static void SendGameRequestToFacebookUser(long fbUid, string title, string message, string data)
		{
		}

		// Token: 0x0600F940 RID: 63808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F940")]
		[Address(RVA = "0x2740D24", Offset = "0x2740D24", VA = "0x7BBCF40D24")]
		public static void ShareToVKontakte(string message, string url, string imagePath, int compressRate)
		{
		}

		// Token: 0x0600F941 RID: 63809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F941")]
		[Address(RVA = "0x2741370", Offset = "0x2741370", VA = "0x7BBCF41370")]
		internal static void SendGameRequestToFacebookUserCallback(string pluginResultString)
		{
		}

		// Token: 0x04011CD7 RID: 72919
		[Token(Token = "0x4011CD7")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _Share;

		// Token: 0x02002C02 RID: 11266
		[Token(Token = "0x2002C02")]
		[Serializable]
		public class PluginResult
		{
			// Token: 0x0600F943 RID: 63811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F943")]
			[Address(RVA = "0x2741504", Offset = "0x2741504", VA = "0x7BBCF41504")]
			public PluginResult()
			{
			}

			// Token: 0x04011CD8 RID: 72920
			[Token(Token = "0x4011CD8")]
			[FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04011CD9 RID: 72921
			[Token(Token = "0x4011CD9")]
			[FieldOffset(Offset = "0x18")]
			public string message;

			// Token: 0x04011CDA RID: 72922
			[Token(Token = "0x4011CDA")]
			[FieldOffset(Offset = "0x20")]
			public string source;

			// Token: 0x04011CDB RID: 72923
			[Token(Token = "0x4011CDB")]
			[FieldOffset(Offset = "0x28")]
			public int flag;
		}
	}
}
