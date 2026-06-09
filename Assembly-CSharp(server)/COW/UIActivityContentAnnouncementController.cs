using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013E7 RID: 5095
	[Token(Token = "0x20013E7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC1B0", Offset = "0x10EC1B0")]
	public class UIActivityContentAnnouncementController : UIActivityContentController
	{
		// Token: 0x060053B9 RID: 21433 RVA: 0x00018FF0 File Offset: 0x000171F0
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x1A4A75C", Offset = "0x1A4A75C", VA = "0x7BBC24A75C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x1A4A7AC", Offset = "0x1A4A7AC", VA = "0x7BBC24A7AC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x1A4AD50", Offset = "0x1A4AD50", VA = "0x7BBC24AD50", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0x1A4AD58", Offset = "0x1A4AD58", VA = "0x7BBC24AD58", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0x1A4AFB0", Offset = "0x1A4AFB0", VA = "0x7BBC24AFB0")]
		private void OnOperate()
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x1A4AFD4", Offset = "0x1A4AFD4", VA = "0x7BBC24AFD4")]
		private void OpenCommunityWebsite(bool facebook = false, bool offical = false)
		{
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x1A4AA34", Offset = "0x1A4AA34", VA = "0x7BBC24AA34")]
		private CommunityWebsiteData GetCommunityWebsiteData()
		{
			return null;
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x1A4B148", Offset = "0x1A4B148", VA = "0x7BBC24B148")]
		public UIActivityContentAnnouncementController()
		{
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x1A4B150", Offset = "0x1A4B150", VA = "0x7BBC24B150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E5E4", Offset = "0x113E5E4")]
		private void <OnUIInit>b__5_0()
		{
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x1A4B15C", Offset = "0x1A4B15C", VA = "0x7BBC24B15C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E5F4", Offset = "0x113E5F4")]
		private void <OnUIInit>b__5_1()
		{
		}

		// Token: 0x0400794E RID: 31054
		[Token(Token = "0x400794E")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityContentAnnouncementView m_View;

		// Token: 0x0400794F RID: 31055
		[Token(Token = "0x400794F")]
		[FieldOffset(Offset = "0x60")]
		private UIActivityContentAnnouncementController.Data m_SelectInfo;

		// Token: 0x04007950 RID: 31056
		[Token(Token = "0x4007950")]
		[FieldOffset(Offset = "0x68")]
		private CommunityWebsiteData m_websiteData;

		// Token: 0x020013E8 RID: 5096
		[Token(Token = "0x20013E8")]
		public class Data
		{
			// Token: 0x060053C3 RID: 21443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053C3")]
			[Address(RVA = "0x1A4B168", Offset = "0x1A4B168", VA = "0x7BBC24B168")]
			public Data(string introduction, uint goPos, string subGoPos, bool prefersExternal, string image_url)
			{
			}

			// Token: 0x04007951 RID: 31057
			[Token(Token = "0x4007951")]
			[FieldOffset(Offset = "0x10")]
			public string introduction;

			// Token: 0x04007952 RID: 31058
			[Token(Token = "0x4007952")]
			[FieldOffset(Offset = "0x18")]
			public uint goPos;

			// Token: 0x04007953 RID: 31059
			[Token(Token = "0x4007953")]
			[FieldOffset(Offset = "0x20")]
			public string subGoPos;

			// Token: 0x04007954 RID: 31060
			[Token(Token = "0x4007954")]
			[FieldOffset(Offset = "0x28")]
			public bool prefersExternal;

			// Token: 0x04007955 RID: 31061
			[Token(Token = "0x4007955")]
			[FieldOffset(Offset = "0x30")]
			public string image_url;
		}
	}
}
