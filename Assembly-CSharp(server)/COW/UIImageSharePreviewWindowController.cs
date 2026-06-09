using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019B7 RID: 6583
	[Token(Token = "0x20019B7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6E74", Offset = "0x10F6E74")]
	internal class UIImageSharePreviewWindowController : UIPopupWindowController
	{
		// Token: 0x060086FA RID: 34554 RVA: 0x000247F8 File Offset: 0x000229F8
		[Token(Token = "0x60086FA")]
		[Address(RVA = "0x138CD0C", Offset = "0x138CD0C", VA = "0x7BBBB8CD0C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086FB")]
		[Address(RVA = "0x138CD5C", Offset = "0x138CD5C", VA = "0x7BBBB8CD5C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086FC")]
		[Address(RVA = "0x138DA34", Offset = "0x138DA34", VA = "0x7BBBB8DA34", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086FD")]
		[Address(RVA = "0x138DA6C", Offset = "0x138DA6C", VA = "0x7BBBB8DA6C")]
		public void OnCloseClick()
		{
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086FE")]
		[Address(RVA = "0x138DA74", Offset = "0x138DA74", VA = "0x7BBBB8DA74")]
		public void ShareImage(UIBaseController target, ShareImageData data)
		{
		}

		// Token: 0x060086FF RID: 34559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086FF")]
		[Address(RVA = "0x138DC58", Offset = "0x138DC58", VA = "0x7BBBB8DC58")]
		private void UpdateShareImage()
		{
		}

		// Token: 0x06008700 RID: 34560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008700")]
		[Address(RVA = "0x138E3C4", Offset = "0x138E3C4", VA = "0x7BBBB8E3C4")]
		public void UpdateSharePreview(int width, int height)
		{
		}

		// Token: 0x06008701 RID: 34561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008701")]
		[Address(RVA = "0x138D2B0", Offset = "0x138D2B0", VA = "0x7BBBB8D2B0")]
		private void UpdateUI()
		{
		}

		// Token: 0x06008702 RID: 34562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008702")]
		[Address(RVA = "0x138E44C", Offset = "0x138E44C", VA = "0x7BBBB8E44C")]
		private void OnShareClick(EventLogger.SharePlatform platform)
		{
		}

		// Token: 0x06008703 RID: 34563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008703")]
		[Address(RVA = "0x138F3A8", Offset = "0x138F3A8", VA = "0x7BBBB8F3A8")]
		private void SendLimitedEventShareLog(uint id, uint platform)
		{
		}

		// Token: 0x06008704 RID: 34564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008704")]
		[Address(RVA = "0x138EF18", Offset = "0x138EF18", VA = "0x7BBBB8EF18")]
		private void SendPortraitCloseupShareLog(uint platform)
		{
		}

		// Token: 0x06008705 RID: 34565 RVA: 0x00024810 File Offset: 0x00022A10
		[Token(Token = "0x6008705")]
		[Address(RVA = "0x138E5D8", Offset = "0x138E5D8", VA = "0x7BBBB8E5D8")]
		private bool OnShareLineBtnClick()
		{
			return default(bool);
		}

		// Token: 0x06008706 RID: 34566 RVA: 0x00024828 File Offset: 0x00022A28
		[Token(Token = "0x6008706")]
		[Address(RVA = "0x138EB94", Offset = "0x138EB94", VA = "0x7BBBB8EB94")]
		private bool OnShareVKBtnClick()
		{
			return default(bool);
		}

		// Token: 0x06008707 RID: 34567 RVA: 0x00024840 File Offset: 0x00022A40
		[Token(Token = "0x6008707")]
		[Address(RVA = "0x138ECD4", Offset = "0x138ECD4", VA = "0x7BBBB8ECD4")]
		private bool OnOtherShareBtnClick()
		{
			return default(bool);
		}

		// Token: 0x06008708 RID: 34568 RVA: 0x00024858 File Offset: 0x00022A58
		[Token(Token = "0x6008708")]
		[Address(RVA = "0x138E7D8", Offset = "0x138E7D8", VA = "0x7BBBB8E7D8")]
		private bool OnShareFBBtnClick()
		{
			return default(bool);
		}

		// Token: 0x06008709 RID: 34569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008709")]
		[Address(RVA = "0x138F530", Offset = "0x138F530", VA = "0x7BBBB8F530")]
		public void OnDownloadToAlbumBtnClick()
		{
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600870A")]
		[Address(RVA = "0x138F7E4", Offset = "0x138F7E4", VA = "0x7BBBB8F7E4")]
		private void OnImageSaveToAlbumDone(string error)
		{
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600870B")]
		[Address(RVA = "0x138FC7C", Offset = "0x138FC7C", VA = "0x7BBBB8FC7C")]
		private void OnCopyLink()
		{
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600870C")]
		[Address(RVA = "0x138F0D0", Offset = "0x138F0D0", VA = "0x7BBBB8F0D0")]
		private void DoneShare(bool success, EventLogger.SharePlatform sharePlatform)
		{
		}

		// Token: 0x0600870D RID: 34573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600870D")]
		[Address(RVA = "0x1390084", Offset = "0x1390084", VA = "0x7BBBB90084")]
		public UIImageSharePreviewWindowController()
		{
		}

		// Token: 0x0600870E RID: 34574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600870E")]
		[Address(RVA = "0x13900EC", Offset = "0x13900EC", VA = "0x7BBBB900EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114355C", Offset = "0x114355C")]
		private void <OnUIInit>b__6_0()
		{
		}

		// Token: 0x0600870F RID: 34575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600870F")]
		[Address(RVA = "0x13900F4", Offset = "0x13900F4", VA = "0x7BBBB900F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114356C", Offset = "0x114356C")]
		private void <OnUIInit>b__6_1()
		{
		}

		// Token: 0x06008710 RID: 34576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008710")]
		[Address(RVA = "0x13900FC", Offset = "0x13900FC", VA = "0x7BBBB900FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114357C", Offset = "0x114357C")]
		private void <OnUIInit>b__6_2()
		{
		}

		// Token: 0x06008711 RID: 34577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008711")]
		[Address(RVA = "0x1390104", Offset = "0x1390104", VA = "0x7BBBB90104")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114358C", Offset = "0x114358C")]
		private void <OnUIInit>b__6_3()
		{
		}

		// Token: 0x06008712 RID: 34578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008712")]
		[Address(RVA = "0x139010C", Offset = "0x139010C", VA = "0x7BBBB9010C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114359C", Offset = "0x114359C")]
		private void <OnUIInit>b__6_4()
		{
		}

		// Token: 0x06008713 RID: 34579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008713")]
		[Address(RVA = "0x1390114", Offset = "0x1390114", VA = "0x7BBBB90114")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11435AC", Offset = "0x11435AC")]
		private void <OnUIInit>b__6_5()
		{
		}

		// Token: 0x06008714 RID: 34580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008714")]
		[Address(RVA = "0x139011C", Offset = "0x139011C", VA = "0x7BBBB9011C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11435BC", Offset = "0x11435BC")]
		private void <OnUIInit>b__6_6()
		{
		}

		// Token: 0x06008715 RID: 34581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008715")]
		[Address(RVA = "0x1390124", Offset = "0x1390124", VA = "0x7BBBB90124")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11435CC", Offset = "0x11435CC")]
		private void <OnUIInit>b__6_7()
		{
		}

		// Token: 0x040095CB RID: 38347
		[Token(Token = "0x40095CB")]
		[FieldOffset(Offset = "0x98")]
		public Action OnClose;

		// Token: 0x040095CC RID: 38348
		[Token(Token = "0x40095CC")]
		[FieldOffset(Offset = "0xA0")]
		private UIImageSharePreviewWindowView m_View;

		// Token: 0x040095CD RID: 38349
		[Token(Token = "0x40095CD")]
		[FieldOffset(Offset = "0xA8")]
		private ShareSettingData m_ShareSetting;

		// Token: 0x040095CE RID: 38350
		[Token(Token = "0x40095CE")]
		[FieldOffset(Offset = "0xB0")]
		private UIBaseController m_Target;

		// Token: 0x040095CF RID: 38351
		[Token(Token = "0x40095CF")]
		private const uint HEIGHTOFFSETINPORTRAIT = 24U;

		// Token: 0x040095D0 RID: 38352
		[Token(Token = "0x40095D0")]
		[FieldOffset(Offset = "0xB8")]
		private ShareImageData m_Data;

		// Token: 0x020019B8 RID: 6584
		[Token(Token = "0x20019B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6EAC", Offset = "0x10F6EAC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008717 RID: 34583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008717")]
			[Address(RVA = "0x1390190", Offset = "0x1390190", VA = "0x7BBBB90190")]
			public <>c()
			{
			}

			// Token: 0x06008718 RID: 34584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008718")]
			[Address(RVA = "0x1390198", Offset = "0x1390198", VA = "0x7BBBB90198")]
			internal void <DoneShare>b__24_0(HttpErrorCode errCode, object obj)
			{
			}

			// Token: 0x040095D1 RID: 38353
			[Token(Token = "0x40095D1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIImageSharePreviewWindowController.<>c <>9;

			// Token: 0x040095D2 RID: 38354
			[Token(Token = "0x40095D2")]
			[FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__24_0;
		}
	}
}
