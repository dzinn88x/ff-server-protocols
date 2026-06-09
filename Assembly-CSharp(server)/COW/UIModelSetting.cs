using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FED RID: 8173
	[Token(Token = "0x2001FED")]
	public class UIModelSetting : UIBaseModel
	{
		// Token: 0x0600B5D9 RID: 46553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D9")]
		[Address(RVA = "0x22F3A90", Offset = "0x22F3A90", VA = "0x7BBCAF3A90", Slot = "11")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B5DA RID: 46554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5DA")]
		[Address(RVA = "0x22F3BB8", Offset = "0x22F3BB8", VA = "0x7BBCAF3BB8")]
		public string GetSettingMD5()
		{
			return null;
		}

		// Token: 0x0600B5DB RID: 46555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DB")]
		[Address(RVA = "0x22F4BF8", Offset = "0x22F4BF8", VA = "0x7BBCAF4BF8")]
		public void CheckUploadSetting()
		{
		}

		// Token: 0x0600B5DC RID: 46556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DC")]
		[Address(RVA = "0x22F52AC", Offset = "0x22F52AC", VA = "0x7BBCAF52AC")]
		public void UploadSetting()
		{
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DD")]
		[Address(RVA = "0x22F52F0", Offset = "0x22F52F0", VA = "0x7BBCAF52F0")]
		public void RequestUploadSetting()
		{
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DE")]
		[Address(RVA = "0x22F54E4", Offset = "0x22F54E4", VA = "0x7BBCAF54E4")]
		public void CheckDownloadSetting()
		{
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DF")]
		[Address(RVA = "0x22F5750", Offset = "0x22F5750", VA = "0x7BBCAF5750")]
		public void DownloadSetting()
		{
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E0")]
		[Address(RVA = "0x22F5908", Offset = "0x22F5908", VA = "0x7BBCAF5908")]
		private void GetDownloadedHudConfig(string pos, Dictionary<string, HudConfigItem> hudChanged)
		{
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E1")]
		[Address(RVA = "0x22F5D60", Offset = "0x22F5D60", VA = "0x7BBCAF5D60")]
		private void CompareHudConfigForDownload()
		{
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E2")]
		[Address(RVA = "0x22F60E8", Offset = "0x22F60E8", VA = "0x7BBCAF60E8")]
		private void SetHudConfig()
		{
		}

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E3")]
		[Address(RVA = "0x22F61DC", Offset = "0x22F61DC", VA = "0x7BBCAF61DC")]
		private void SetOtherConfig(SettingDetail settingDetail)
		{
		}

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E4")]
		[Address(RVA = "0x22F4E24", Offset = "0x22F4E24", VA = "0x7BBCAF4E24")]
		private void GetDefaultHudConfig()
		{
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E5")]
		[Address(RVA = "0x22F4EDC", Offset = "0x22F4EDC", VA = "0x7BBCAF4EDC")]
		private void LoadHudConfigFromPlayerPref()
		{
		}

		// Token: 0x0600B5E6 RID: 46566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E6")]
		[Address(RVA = "0x22F4F94", Offset = "0x22F4F94", VA = "0x7BBCAF4F94")]
		private void CompareHudConfigForUpload()
		{
		}

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E7")]
		[Address(RVA = "0x22F6F00", Offset = "0x22F6F00", VA = "0x7BBCAF6F00")]
		public void SetSettingGuide()
		{
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x00033CD8 File Offset: 0x00031ED8
		[Token(Token = "0x600B5E8")]
		[Address(RVA = "0x22F6F74", Offset = "0x22F6F74", VA = "0x7BBCAF6F74")]
		public int GetSettingGuide()
		{
			return 0;
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E9")]
		[Address(RVA = "0x22F6FE8", Offset = "0x22F6FE8", VA = "0x7BBCAF6FE8")]
		public void InitSettingLogAll()
		{
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EA")]
		[Address(RVA = "0x22F74CC", Offset = "0x22F74CC", VA = "0x7BBCAF74CC")]
		public void GetNowSettingLogAll()
		{
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x00033CF0 File Offset: 0x00031EF0
		[Token(Token = "0x600B5EB")]
		[Address(RVA = "0x22F79B0", Offset = "0x22F79B0", VA = "0x7BBCAF79B0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EC")]
		[Address(RVA = "0x22F79B8", Offset = "0x22F79B8", VA = "0x7BBCAF79B8")]
		public UIModelSetting()
		{
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5ED")]
		[Address(RVA = "0x22F7B48", Offset = "0x22F7B48", VA = "0x7BBCAF7B48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114751C", Offset = "0x114751C")]
		private void <CheckUploadSetting>b__24_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EE")]
		[Address(RVA = "0x22F7CF4", Offset = "0x22F7CF4", VA = "0x7BBCAF7CF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114752C", Offset = "0x114752C")]
		private void <RequestUploadSetting>b__26_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EF")]
		[Address(RVA = "0x22F7E50", Offset = "0x22F7E50", VA = "0x7BBCAF7E50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114753C", Offset = "0x114753C")]
		private void <CheckDownloadSetting>b__27_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5F0")]
		[Address(RVA = "0x22F7FFC", Offset = "0x22F7FFC", VA = "0x7BBCAF7FFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114754C", Offset = "0x114754C")]
		private void <DownloadSetting>b__28_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B7D8 RID: 47064
		[Token(Token = "0x400B7D8")]
		public const int PropID_UploadSettingCover = 1;

		// Token: 0x0400B7D9 RID: 47065
		[Token(Token = "0x400B7D9")]
		public const int PropID_UploadSettingStart = 2;

		// Token: 0x0400B7DA RID: 47066
		[Token(Token = "0x400B7DA")]
		public const int PropID_UploadSettingFinish = 4;

		// Token: 0x0400B7DB RID: 47067
		[Token(Token = "0x400B7DB")]
		public const int PropID_DownloadSettingCover = 8;

		// Token: 0x0400B7DC RID: 47068
		[Token(Token = "0x400B7DC")]
		public const int PropID_DownloadSettingFailure = 16;

		// Token: 0x0400B7DD RID: 47069
		[Token(Token = "0x400B7DD")]
		public const int PropID_DownloadSettingFinish = 32;

		// Token: 0x0400B7DE RID: 47070
		[Token(Token = "0x400B7DE")]
		public const int PropID_UploadFailure = 64;

		// Token: 0x0400B7DF RID: 47071
		[Token(Token = "0x400B7DF")]
		public const int PropID_DownloadFailure = 128;

		// Token: 0x0400B7E0 RID: 47072
		[Token(Token = "0x400B7E0")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, HudConfigItem> m_HudDefaultConfigDic;

		// Token: 0x0400B7E1 RID: 47073
		[Token(Token = "0x400B7E1")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, HudConfigItem> m_HudCustomizeConfigDic;

		// Token: 0x0400B7E2 RID: 47074
		[Token(Token = "0x400B7E2")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, HudConfigItem> m_HudChangedConfigDic;

		// Token: 0x0400B7E3 RID: 47075
		[Token(Token = "0x400B7E3")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, HudConfigItem> m_HudNewDefaultConfigDic;

		// Token: 0x0400B7E4 RID: 47076
		[Token(Token = "0x400B7E4")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, HudConfigItem> m_HudNewCustomizeConfigDic;

		// Token: 0x0400B7E5 RID: 47077
		[Token(Token = "0x400B7E5")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, HudConfigItem> m_HudNewChangedConfigDic;

		// Token: 0x0400B7E6 RID: 47078
		[Token(Token = "0x400B7E6")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, object> m_ChangedSettingDic;

		// Token: 0x0400B7E7 RID: 47079
		[Token(Token = "0x400B7E7")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, object> m_TotalChangedSettingDic;

		// Token: 0x0400B7E8 RID: 47080
		[Token(Token = "0x400B7E8")]
		[FieldOffset(Offset = "0x58")]
		private string m_SettingSyncGuide;

		// Token: 0x0400B7E9 RID: 47081
		[Token(Token = "0x400B7E9")]
		[FieldOffset(Offset = "0x60")]
		private SettingDetail m_SettingDetail;

		// Token: 0x0400B7EA RID: 47082
		[Token(Token = "0x400B7EA")]
		[FieldOffset(Offset = "0x68")]
		private byte[] m_SettingDetailSerialized;

		// Token: 0x0400B7EB RID: 47083
		[Token(Token = "0x400B7EB")]
		[FieldOffset(Offset = "0x70")]
		private string m_Version;

		// Token: 0x0400B7EC RID: 47084
		[Token(Token = "0x400B7EC")]
		[FieldOffset(Offset = "0x78")]
		private SettingsTransferStatus m_Flag;

		// Token: 0x02001FEE RID: 8174
		[Token(Token = "0x2001FEE")]
		public enum SyncStatus
		{
			// Token: 0x0400B7EE RID: 47086
			[Token(Token = "0x400B7EE")]
			UpCover,
			// Token: 0x0400B7EF RID: 47087
			[Token(Token = "0x400B7EF")]
			DownCover,
			// Token: 0x0400B7F0 RID: 47088
			[Token(Token = "0x400B7F0")]
			Success,
			// Token: 0x0400B7F1 RID: 47089
			[Token(Token = "0x400B7F1")]
			Failure,
			// Token: 0x0400B7F2 RID: 47090
			[Token(Token = "0x400B7F2")]
			UploadFailure,
			// Token: 0x0400B7F3 RID: 47091
			[Token(Token = "0x400B7F3")]
			DownloadSuccess,
			// Token: 0x0400B7F4 RID: 47092
			[Token(Token = "0x400B7F4")]
			DownloadFailure
		}
	}
}
