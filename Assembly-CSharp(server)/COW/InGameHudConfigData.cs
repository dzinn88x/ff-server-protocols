using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using LitJson;

namespace COW
{
	// Token: 0x0200110E RID: 4366
	[Token(Token = "0x200110E")]
	public class InGameHudConfigData : SingletonModule<InGameHudConfigData>
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080F")]
		public string HudVersionKey
		{
			[Token(Token = "0x6004449")]
			[Address(RVA = "0x185AB6C", Offset = "0x185AB6C", VA = "0x7BBC05AB6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600444A RID: 17482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000810")]
		public Dictionary<string, HudConfigItem> HudDefaultConfigDic
		{
			[Token(Token = "0x600444A")]
			[Address(RVA = "0x185ABB4", Offset = "0x185ABB4", VA = "0x7BBC05ABB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000811")]
		public Dictionary<string, HudConfigItem> HudNewDefaultConfigDic
		{
			[Token(Token = "0x600444B")]
			[Address(RVA = "0x185ABBC", Offset = "0x185ABBC", VA = "0x7BBC05ABBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000812")]
		public Dictionary<string, HudConfigItem> HudCustomizeConfigDic
		{
			[Token(Token = "0x600444C")]
			[Address(RVA = "0x185ABC4", Offset = "0x185ABC4", VA = "0x7BBC05ABC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000813")]
		public Dictionary<string, HudConfigItem> HudNewCustomizeConfigDic
		{
			[Token(Token = "0x600444D")]
			[Address(RVA = "0x185ABCC", Offset = "0x185ABCC", VA = "0x7BBC05ABCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600444E RID: 17486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x185ABD4", Offset = "0x185ABD4", VA = "0x7BBC05ABD4", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x185B904", Offset = "0x185B904", VA = "0x7BBC05B904")]
		public void SetCurrent()
		{
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004450")]
		[Address(RVA = "0x185B994", Offset = "0x185B994", VA = "0x7BBC05B994", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004451")]
		[Address(RVA = "0x185BA7C", Offset = "0x185BA7C", VA = "0x7BBC05BA7C")]
		private void LoadDataFromJsonData(JsonData JObjRoot)
		{
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004452")]
		[Address(RVA = "0x185ADF8", Offset = "0x185ADF8", VA = "0x7BBC05ADF8")]
		private void LoadNewDataFromConfig()
		{
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004453")]
		[Address(RVA = "0x185AC18", Offset = "0x185AC18", VA = "0x7BBC05AC18")]
		private void LoadDataFromConfig()
		{
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x185BF2C", Offset = "0x185BF2C", VA = "0x7BBC05BF2C")]
		private void LoadCustomizeDataFromJsonData(JsonData JHud)
		{
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004455")]
		[Address(RVA = "0x185B6EC", Offset = "0x185B6EC", VA = "0x7BBC05B6EC")]
		private void LoadDataFromPlayerPref()
		{
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x185B7F8", Offset = "0x185B7F8", VA = "0x7BBC05B7F8")]
		private void LoadNewDataFromPlayerPref()
		{
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004457")]
		[Address(RVA = "0x185AF10", Offset = "0x185AF10", VA = "0x7BBC05AF10")]
		private void CheckOldVersion()
		{
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x185C3E8", Offset = "0x185C3E8", VA = "0x7BBC05C3E8")]
		public void RefreshDataFromPlayerPref()
		{
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004459")]
		[Address(RVA = "0x185C40C", Offset = "0x185C40C", VA = "0x7BBC05C40C")]
		public void SetDefaultHudConfigByStyle(bool isStyleNew)
		{
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00014FD0 File Offset: 0x000131D0
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x185C964", Offset = "0x185C964", VA = "0x7BBC05C964")]
		public bool HasCustomized(string hudName)
		{
			return default(bool);
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x185CA28", Offset = "0x185CA28", VA = "0x7BBC05CA28")]
		public HudConfigItem GetHudDefaultConfigByName(string HudName)
		{
			return null;
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x185CAA8", Offset = "0x185CAA8", VA = "0x7BBC05CAA8")]
		public HudConfigItem GetHudCustomizeConfigByName(string HudName)
		{
			return null;
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445D")]
		[Address(RVA = "0x185CB28", Offset = "0x185CB28", VA = "0x7BBC05CB28")]
		public void ChangeCustomizedConfig(string HudName, HudConfigItem configItem)
		{
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445E")]
		[Address(RVA = "0x185CBBC", Offset = "0x185CBBC", VA = "0x7BBC05CBBC")]
		public void SaveDownloadedConfig(Dictionary<string, HudConfigItem> hud)
		{
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445F")]
		[Address(RVA = "0x185CD5C", Offset = "0x185CD5C", VA = "0x7BBC05CD5C")]
		public void SaveCustomizedConfig([Optional] List<string> excludeList)
		{
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x00014FE8 File Offset: 0x000131E8
		[Token(Token = "0x6004460")]
		[Address(RVA = "0x185C9F0", Offset = "0x185C9F0", VA = "0x7BBC05C9F0")]
		public bool EqualToDefaultConfig(string key, HudConfigItem CustomizeConfig)
		{
			return default(bool);
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004461")]
		[Address(RVA = "0x185CE84", Offset = "0x185CE84", VA = "0x7BBC05CE84")]
		public InGameHudConfigData()
		{
		}

		// Token: 0x0400544C RID: 21580
		[Token(Token = "0x400544C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, HudConfigItem> m_HudDefaultConfigDic;

		// Token: 0x0400544D RID: 21581
		[Token(Token = "0x400544D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, HudConfigItem> m_HudNewDefaultConfigDic;

		// Token: 0x0400544E RID: 21582
		[Token(Token = "0x400544E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, HudConfigItem> m_HudCustomizeConfigDic;

		// Token: 0x0400544F RID: 21583
		[Token(Token = "0x400544F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, HudConfigItem> m_HudNewCustomizeConfigDic;

		// Token: 0x04005450 RID: 21584
		[Token(Token = "0x4005450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, HudConfigItem> m_HudCurrentDefaultConfigDic;

		// Token: 0x04005451 RID: 21585
		[Token(Token = "0x4005451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, HudConfigItem> m_HudCurrentCustomizeConfigDic;

		// Token: 0x04005452 RID: 21586
		[Token(Token = "0x4005452")]
		private const string m_LeftFireKey = "HudAuxFire";

		// Token: 0x04005453 RID: 21587
		[Token(Token = "0x4005453")]
		private const string m_HudVersionKey = "HudVersion";
	}
}
