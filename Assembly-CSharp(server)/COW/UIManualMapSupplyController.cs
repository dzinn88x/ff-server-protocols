using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A55 RID: 6741
	[Token(Token = "0x2001A55")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7F7C", Offset = "0x10F7F7C")]
	public class UIManualMapSupplyController : UIManualContentBaseController
	{
		// Token: 0x06008DCF RID: 36303 RVA: 0x00025CC8 File Offset: 0x00023EC8
		[Token(Token = "0x6008DCF")]
		[Address(RVA = "0x18E42C0", Offset = "0x18E42C0", VA = "0x7BBC0E42C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD0")]
		[Address(RVA = "0x18E4310", Offset = "0x18E4310", VA = "0x7BBC0E4310", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD1")]
		[Address(RVA = "0x18E4A5C", Offset = "0x18E4A5C", VA = "0x7BBC0E4A5C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD2")]
		[Address(RVA = "0x18E4A64", Offset = "0x18E4A64", VA = "0x7BBC0E4A64", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008DD3 RID: 36307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD3")]
		[Address(RVA = "0x18E4A6C", Offset = "0x18E4A6C", VA = "0x7BBC0E4A6C", Slot = "28")]
		public override void SetData(UIManualDataBase data)
		{
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD4")]
		[Address(RVA = "0x18E4B0C", Offset = "0x18E4B0C", VA = "0x7BBC0E4B0C", Slot = "30")]
		public override void RefreshView()
		{
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x00025CE0 File Offset: 0x00023EE0
		[Token(Token = "0x6008DD5")]
		[Address(RVA = "0x18E4F78", Offset = "0x18E4F78", VA = "0x7BBC0E4F78", Slot = "31")]
		protected override int GetMaxPage()
		{
			return 0;
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD6")]
		[Address(RVA = "0x18E50C8", Offset = "0x18E50C8", VA = "0x7BBC0E50C8")]
		public void RefreshRightContent(ManualInMapData data)
		{
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD7")]
		[Address(RVA = "0x18E5804", Offset = "0x18E5804", VA = "0x7BBC0E5804")]
		public void RefreshLeftSelectState()
		{
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD8")]
		[Address(RVA = "0x18E553C", Offset = "0x18E553C", VA = "0x7BBC0E553C")]
		private void SetIcon(UISprite icon, ManualInMapData data)
		{
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DD9")]
		[Address(RVA = "0x18E4628", Offset = "0x18E4628", VA = "0x7BBC0E4628")]
		private void InitSupplyList()
		{
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DDA")]
		[Address(RVA = "0x18E5E08", Offset = "0x18E5E08", VA = "0x7BBC0E5E08")]
		private void RestSupplyList()
		{
		}

		// Token: 0x06008DDB RID: 36315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DDB")]
		[Address(RVA = "0x18E49A4", Offset = "0x18E49A4", VA = "0x7BBC0E49A4")]
		private void ShowRightContent(bool v)
		{
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DDC")]
		[Address(RVA = "0x18E4B38", Offset = "0x18E4B38", VA = "0x7BBC0E4B38")]
		private void DoRefreshView(int pageID)
		{
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DDD")]
		[Address(RVA = "0x18E5F5C", Offset = "0x18E5F5C", VA = "0x7BBC0E5F5C")]
		private void RefreshLeftContent(List<ManualInMapData> data)
		{
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x00025CF8 File Offset: 0x00023EF8
		[Token(Token = "0x6008DDE")]
		[Address(RVA = "0x18E56BC", Offset = "0x18E56BC", VA = "0x7BBC0E56BC")]
		private bool CheckIsUnlock(uint evtId)
		{
			return default(bool);
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DDF")]
		[Address(RVA = "0x18E649C", Offset = "0x18E649C", VA = "0x7BBC0E649C")]
		public void OnClickMore()
		{
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DE0")]
		[Address(RVA = "0x18E64B8", Offset = "0x18E64B8", VA = "0x7BBC0E64B8")]
		public UIManualMapSupplyController()
		{
		}

		// Token: 0x040099AB RID: 39339
		[Token(Token = "0x40099AB")]
		[FieldOffset(Offset = "0x78")]
		private UIManualMapSupplyView m_View;

		// Token: 0x040099AC RID: 39340
		[Token(Token = "0x40099AC")]
		[FieldOffset(Offset = "0x80")]
		private UIManualMapSupplyData m_Data;

		// Token: 0x040099AD RID: 39341
		[Token(Token = "0x40099AD")]
		[FieldOffset(Offset = "0x88")]
		private ManualInMapData m_CurSelectedData;

		// Token: 0x040099AE RID: 39342
		[Token(Token = "0x40099AE")]
		[FieldOffset(Offset = "0x90")]
		private List<GameObject> m_SupplyList;

		// Token: 0x040099AF RID: 39343
		[Token(Token = "0x40099AF")]
		[FieldOffset(Offset = "0x98")]
		private List<UIManualMapSupplyItemController> m_ItmCtlList;

		// Token: 0x040099B0 RID: 39344
		[Token(Token = "0x40099B0")]
		[FieldOffset(Offset = "0xA0")]
		private UIScrollView m_LabelScrollView;

		// Token: 0x040099B1 RID: 39345
		[Token(Token = "0x40099B1")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject m_LeftArrowTips;

		// Token: 0x040099B2 RID: 39346
		[Token(Token = "0x40099B2")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject m_RightArrowTips;

		// Token: 0x02001A56 RID: 6742
		[Token(Token = "0x2001A56")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7FB4", Offset = "0x10F7FB4")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06008DE1 RID: 36321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008DE1")]
			[Address(RVA = "0x18E5F54", Offset = "0x18E5F54", VA = "0x7BBC0E5F54")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06008DE2 RID: 36322 RVA: 0x00025D10 File Offset: 0x00023F10
			[Token(Token = "0x6008DE2")]
			[Address(RVA = "0x18E6550", Offset = "0x18E6550", VA = "0x7BBC0E6550")]
			internal bool <DoRefreshView>b__0(ManualInMapData e)
			{
				return default(bool);
			}

			// Token: 0x040099B3 RID: 39347
			[Token(Token = "0x40099B3")]
			[FieldOffset(Offset = "0x10")]
			public int pageID;
		}

		// Token: 0x02001A57 RID: 6743
		[Token(Token = "0x2001A57")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7FC4", Offset = "0x10F7FC4")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06008DE3 RID: 36323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008DE3")]
			[Address(RVA = "0x18E6494", Offset = "0x18E6494", VA = "0x7BBC0E6494")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06008DE4 RID: 36324 RVA: 0x00025D28 File Offset: 0x00023F28
			[Token(Token = "0x6008DE4")]
			[Address(RVA = "0x18E658C", Offset = "0x18E658C", VA = "0x7BBC0E658C")]
			internal bool <CheckIsUnlock>b__0(uint e)
			{
				return default(bool);
			}

			// Token: 0x040099B4 RID: 39348
			[Token(Token = "0x40099B4")]
			[FieldOffset(Offset = "0x10")]
			public uint evtId;
		}
	}
}
