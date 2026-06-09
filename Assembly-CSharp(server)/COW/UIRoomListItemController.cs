using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B64 RID: 7012
	[Token(Token = "0x2001B64")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9F14", Offset = "0x10F9F14")]
	public class UIRoomListItemController : UIEasyListItemController
	{
		// Token: 0x060096E0 RID: 38624 RVA: 0x00027D98 File Offset: 0x00025F98
		[Token(Token = "0x60096E0")]
		[Address(RVA = "0x1A16698", Offset = "0x1A16698", VA = "0x7BBC216698")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E1")]
		[Address(RVA = "0x1A166E8", Offset = "0x1A166E8", VA = "0x7BBC2166E8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E2")]
		[Address(RVA = "0x1A169D4", Offset = "0x1A169D4", VA = "0x7BBC2169D4")]
		private void JoinProcess(bool solo = true)
		{
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E3")]
		[Address(RVA = "0x1A16F70", Offset = "0x1A16F70", VA = "0x7BBC216F70")]
		private void SpectateProcess(bool solo = true)
		{
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E4")]
		[Address(RVA = "0x1A173C4", Offset = "0x1A173C4", VA = "0x7BBC2173C4")]
		private void OnRoomItemClick()
		{
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E5")]
		[Address(RVA = "0x1A17D04", Offset = "0x1A17D04", VA = "0x7BBC217D04")]
		private void GeneratePopMenuData()
		{
		}

		// Token: 0x060096E6 RID: 38630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E6")]
		[Address(RVA = "0x1A175B4", Offset = "0x1A175B4", VA = "0x7BBC2175B4")]
		private void GenerateBatchPopMenuData()
		{
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E7")]
		[Address(RVA = "0x1A18014", Offset = "0x1A18014", VA = "0x7BBC218014", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E8")]
		[Address(RVA = "0x1A18824", Offset = "0x1A18824", VA = "0x7BBC218824")]
		private void UpdateGroupModeStatus(RoomBasicInfo data)
		{
		}

		// Token: 0x060096E9 RID: 38633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096E9")]
		[Address(RVA = "0x1A18A78", Offset = "0x1A18A78", VA = "0x7BBC218A78")]
		private void UpdateRoomStatus(ERoom.State status)
		{
		}

		// Token: 0x060096EA RID: 38634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096EA")]
		[Address(RVA = "0x1A18BFC", Offset = "0x1A18BFC", VA = "0x7BBC218BFC")]
		private void HighlightRoomItem(RoomBasicInfo info)
		{
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x00027DB0 File Offset: 0x00025FB0
		[Token(Token = "0x60096EB")]
		[Address(RVA = "0x1A1796C", Offset = "0x1A1796C", VA = "0x7BBC21796C")]
		private bool CheckIsMapAvailabe()
		{
			return default(bool);
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096EC")]
		[Address(RVA = "0x1A18C80", Offset = "0x1A18C80", VA = "0x7BBC218C80")]
		public UIRoomListItemController()
		{
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096ED")]
		[Address(RVA = "0x1A18CF0", Offset = "0x1A18CF0", VA = "0x7BBC218CF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144CD0", Offset = "0x1144CD0")]
		private void <GeneratePopMenuData>b__11_0(object obj)
		{
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096EE")]
		[Address(RVA = "0x1A1970C", Offset = "0x1A1970C", VA = "0x7BBC21970C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144CE0", Offset = "0x1144CE0")]
		private void <GeneratePopMenuData>b__11_2()
		{
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096EF")]
		[Address(RVA = "0x1A19714", Offset = "0x1A19714", VA = "0x7BBC219714")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144CF0", Offset = "0x1144CF0")]
		private void <GeneratePopMenuData>b__11_3()
		{
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F0")]
		[Address(RVA = "0x1A1971C", Offset = "0x1A1971C", VA = "0x7BBC21971C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D00", Offset = "0x1144D00")]
		private void <GeneratePopMenuData>b__11_1(object obj)
		{
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F1")]
		[Address(RVA = "0x1A19FE0", Offset = "0x1A19FE0", VA = "0x7BBC219FE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D10", Offset = "0x1144D10")]
		private void <GeneratePopMenuData>b__11_4()
		{
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F2")]
		[Address(RVA = "0x1A19FE8", Offset = "0x1A19FE8", VA = "0x7BBC219FE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D20", Offset = "0x1144D20")]
		private void <GeneratePopMenuData>b__11_5()
		{
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F3")]
		[Address(RVA = "0x1A19FF0", Offset = "0x1A19FF0", VA = "0x7BBC219FF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D30", Offset = "0x1144D30")]
		private void <GenerateBatchPopMenuData>b__12_0(object obj)
		{
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F4")]
		[Address(RVA = "0x1A1A040", Offset = "0x1A1A040", VA = "0x7BBC21A040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D40", Offset = "0x1144D40")]
		private void <GenerateBatchPopMenuData>b__12_2(object obj)
		{
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F5")]
		[Address(RVA = "0x1A1A240", Offset = "0x1A1A240", VA = "0x7BBC21A240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D50", Offset = "0x1144D50")]
		private void <GenerateBatchPopMenuData>b__12_1(object obj)
		{
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096F6")]
		[Address(RVA = "0x1A1A494", Offset = "0x1A1A494", VA = "0x7BBC21A494")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D60", Offset = "0x1144D60")]
		private void <GenerateBatchPopMenuData>b__12_3()
		{
		}

		// Token: 0x04009F3B RID: 40763
		[Token(Token = "0x4009F3B")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomListItemView m_View;

		// Token: 0x04009F3C RID: 40764
		[Token(Token = "0x4009F3C")]
		[FieldOffset(Offset = "0x78")]
		private RoomBasicInfo m_Data;

		// Token: 0x04009F3D RID: 40765
		[Token(Token = "0x4009F3D")]
		[FieldOffset(Offset = "0x80")]
		private UIModelCustomRoom m_Model;

		// Token: 0x04009F3E RID: 40766
		[Token(Token = "0x4009F3E")]
		[FieldOffset(Offset = "0x88")]
		private List<CommonPopMenuData> m_List;

		// Token: 0x04009F3F RID: 40767
		[Token(Token = "0x4009F3F")]
		[FieldOffset(Offset = "0x90")]
		private CommonPopMenuData m_JoinData;

		// Token: 0x04009F40 RID: 40768
		[Token(Token = "0x4009F40")]
		[FieldOffset(Offset = "0x98")]
		private CommonPopMenuData m_SpectateData;

		// Token: 0x02001B65 RID: 7013
		[Token(Token = "0x2001B65")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9F4C", Offset = "0x10F9F4C")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060096F7 RID: 38647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096F7")]
			[Address(RVA = "0x1A16E8C", Offset = "0x1A16E8C", VA = "0x7BBC216E8C")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x060096F8 RID: 38648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096F8")]
			[Address(RVA = "0x1A1A4EC", Offset = "0x1A1A4EC", VA = "0x7BBC21A4EC")]
			internal void <JoinProcess>b__0(string code, string group, string groupAbbr)
			{
			}

			// Token: 0x04009F41 RID: 40769
			[Token(Token = "0x4009F41")]
			[FieldOffset(Offset = "0x10")]
			public UIRoomListItemController <>4__this;

			// Token: 0x04009F42 RID: 40770
			[Token(Token = "0x4009F42")]
			[FieldOffset(Offset = "0x18")]
			public bool solo;
		}

		// Token: 0x02001B66 RID: 7014
		[Token(Token = "0x2001B66")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9F5C", Offset = "0x10F9F5C")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060096F9 RID: 38649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096F9")]
			[Address(RVA = "0x1A173BC", Offset = "0x1A173BC", VA = "0x7BBC2173BC")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x060096FA RID: 38650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096FA")]
			[Address(RVA = "0x1A1A824", Offset = "0x1A1A824", VA = "0x7BBC21A824")]
			internal void <SpectateProcess>b__0(string code, string group, string groupAbbr)
			{
			}

			// Token: 0x04009F43 RID: 40771
			[Token(Token = "0x4009F43")]
			[FieldOffset(Offset = "0x10")]
			public UIRoomListItemController <>4__this;

			// Token: 0x04009F44 RID: 40772
			[Token(Token = "0x4009F44")]
			[FieldOffset(Offset = "0x18")]
			public bool solo;
		}

		// Token: 0x02001B67 RID: 7015
		[Token(Token = "0x2001B67")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9F6C", Offset = "0x10F9F6C")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060096FB RID: 38651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096FB")]
			[Address(RVA = "0x1A1A48C", Offset = "0x1A1A48C", VA = "0x7BBC21A48C")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x060096FC RID: 38652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60096FC")]
			[Address(RVA = "0x1A1A4E4", Offset = "0x1A1A4E4", VA = "0x7BBC21A4E4")]
			internal void <GenerateBatchPopMenuData>b__4()
			{
			}

			// Token: 0x04009F45 RID: 40773
			[Token(Token = "0x4009F45")]
			[FieldOffset(Offset = "0x10")]
			public UIPopupMessageBoxController quitDialog;
		}
	}
}
