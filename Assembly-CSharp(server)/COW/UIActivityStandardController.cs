using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200140A RID: 5130
	[Token(Token = "0x200140A")]
	public class UIActivityStandardController : UIActivityBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005483 RID: 21635 RVA: 0x00019398 File Offset: 0x00017598
		[Token(Token = "0x6005483")]
		[Address(RVA = "0x195ED70", Offset = "0x195ED70", VA = "0x7BBC15ED70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005484")]
		[Address(RVA = "0x195EDC0", Offset = "0x195EDC0", VA = "0x7BBC15EDC0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005485")]
		[Address(RVA = "0x195EFBC", Offset = "0x195EFBC", VA = "0x7BBC15EFBC")]
		private void AdjustWidgtDimFullScreen(UIWidget widget)
		{
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005486")]
		[Address(RVA = "0x195F098", Offset = "0x195F098", VA = "0x7BBC15F098", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005487")]
		[Address(RVA = "0x195F0DC", Offset = "0x195F0DC", VA = "0x7BBC15F0DC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005488")]
		[Address(RVA = "0x195F0E4", Offset = "0x195F0E4", VA = "0x7BBC15F0E4")]
		public void ActivityGroupSelected(int descIndex)
		{
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005489")]
		[Address(RVA = "0x196199C", Offset = "0x196199C", VA = "0x7BBC16199C", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548A")]
		[Address(RVA = "0x1961DAC", Offset = "0x1961DAC", VA = "0x7BBC161DAC")]
		public void UpdateTabData(int tabIndex)
		{
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x000193B0 File Offset: 0x000175B0
		[Token(Token = "0x600548B")]
		[Address(RVA = "0x1961EEC", Offset = "0x1961EEC", VA = "0x7BBC161EEC")]
		private int GetFullWidth()
		{
			return 0;
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548C")]
		[Address(RVA = "0x1962038", Offset = "0x1962038", VA = "0x7BBC162038")]
		private void RemoveGroup(ActivityGroupDesc group)
		{
		}

		// Token: 0x0600548D RID: 21645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548D")]
		[Address(RVA = "0x196203C", Offset = "0x196203C", VA = "0x7BBC16203C", Slot = "29")]
		public override void SelectItem(uint id)
		{
		}

		// Token: 0x0600548E RID: 21646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548E")]
		[Address(RVA = "0x1962150", Offset = "0x1962150", VA = "0x7BBC162150", Slot = "30")]
		public override void OnPanelDepthChanged()
		{
		}

		// Token: 0x0600548F RID: 21647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548F")]
		[Address(RVA = "0x1962200", Offset = "0x1962200", VA = "0x7BBC162200")]
		public void SetAD(string url)
		{
		}

		// Token: 0x06005490 RID: 21648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005490")]
		[Address(RVA = "0x1962304", Offset = "0x1962304", VA = "0x7BBC162304")]
		private void OnDownloadFinish()
		{
		}

		// Token: 0x06005491 RID: 21649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005491")]
		[Address(RVA = "0x1962474", Offset = "0x1962474", VA = "0x7BBC162474", Slot = "31")]
		public override void Reload()
		{
		}

		// Token: 0x06005492 RID: 21650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005492")]
		[Address(RVA = "0x19629A4", Offset = "0x19629A4", VA = "0x7BBC1629A4")]
		public void UpdateSideGroup(uint groupId)
		{
		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005493")]
		[Address(RVA = "0x195F96C", Offset = "0x195F96C", VA = "0x7BBC15F96C")]
		private void UpdateIntroData(ActivityGroupDesc data)
		{
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005494")]
		[Address(RVA = "0x19626D4", Offset = "0x19626D4", VA = "0x7BBC1626D4")]
		private void UpdateActivityInfo()
		{
		}

		// Token: 0x06005495 RID: 21653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005495")]
		[Address(RVA = "0x19608F4", Offset = "0x19608F4", VA = "0x7BBC1608F4")]
		private void CreateThirdTabs()
		{
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005496")]
		[Address(RVA = "0x1962BDC", Offset = "0x1962BDC", VA = "0x7BBC162BDC")]
		private void UpdateThirdTabsTips()
		{
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005497")]
		[Address(RVA = "0x19618A8", Offset = "0x19618A8", VA = "0x7BBC1618A8")]
		private void OnThirdTabSelected(int index)
		{
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005498")]
		[Address(RVA = "0x1962E1C", Offset = "0x1962E1C", VA = "0x7BBC162E1C")]
		private UIActivityContentController OpenThirdTabContent(int index, out object data)
		{
			return null;
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005499")]
		[Address(RVA = "0x195FE1C", Offset = "0x195FE1C", VA = "0x7BBC15FE1C")]
		private UIActivityContentController OpenLargeContent(ActivityGroupDesc desc, out object data)
		{
			return null;
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549A")]
		[Address(RVA = "0x19632C8", Offset = "0x19632C8", VA = "0x7BBC1632C8", Slot = "32")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x000193C8 File Offset: 0x000175C8
		[Token(Token = "0x600549B")]
		[Address(RVA = "0x1963554", Offset = "0x1963554", VA = "0x7BBC163554", Slot = "33")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549C")]
		[Address(RVA = "0x195F844", Offset = "0x195F844", VA = "0x7BBC15F844")]
		private void CloseOldContent()
		{
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549D")]
		[Address(RVA = "0x1963598", Offset = "0x1963598", VA = "0x7BBC163598")]
		public UIActivityStandardController()
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x000193E0 File Offset: 0x000175E0
		[Token(Token = "0x600549E")]
		[Address(RVA = "0x1963658", Offset = "0x1963658", VA = "0x7BBC163658")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E7DC", Offset = "0x113E7DC")]
		private bool <Reload>b__29_0(ActivityGroupDesc e)
		{
			return default(bool);
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x000193F8 File Offset: 0x000175F8
		[Token(Token = "0x600549F")]
		[Address(RVA = "0x19636A4", Offset = "0x19636A4", VA = "0x7BBC1636A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E7EC", Offset = "0x113E7EC")]
		private bool <UpdateSideGroup>b__30_0(ActivityGroupDesc e)
		{
			return default(bool);
		}

		// Token: 0x040079DC RID: 31196
		[Token(Token = "0x40079DC")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityStandardView m_View;

		// Token: 0x040079DD RID: 31197
		[Token(Token = "0x40079DD")]
		[FieldOffset(Offset = "0x60")]
		private List<ActivityGroupDesc> m_GroupDescs;

		// Token: 0x040079DE RID: 31198
		[Token(Token = "0x40079DE")]
		[FieldOffset(Offset = "0x68")]
		private ActivityGroupDesc m_SelectedGroup;

		// Token: 0x040079DF RID: 31199
		[Token(Token = "0x40079DF")]
		[FieldOffset(Offset = "0x70")]
		private ActivityGroupDesc m_LastEaterGroup;

		// Token: 0x040079E0 RID: 31200
		[Token(Token = "0x40079E0")]
		[FieldOffset(Offset = "0x78")]
		private UIActivityCollectionEventController m_LastEasterContent;

		// Token: 0x040079E1 RID: 31201
		[Token(Token = "0x40079E1")]
		[FieldOffset(Offset = "0x80")]
		private UIActivityContentController m_Content;

		// Token: 0x040079E2 RID: 31202
		[Token(Token = "0x40079E2")]
		[FieldOffset(Offset = "0x88")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040079E3 RID: 31203
		[Token(Token = "0x40079E3")]
		[FieldOffset(Offset = "0x90")]
		private ActivityGroupDesc m_GroupDesc;

		// Token: 0x040079E4 RID: 31204
		[Token(Token = "0x40079E4")]
		[FieldOffset(Offset = "0x98")]
		private List<UIToggleButton> m_ThirdToggles;

		// Token: 0x040079E5 RID: 31205
		[Token(Token = "0x40079E5")]
		[FieldOffset(Offset = "0xA0")]
		private UIGrid m_ThirdTabsGrid;

		// Token: 0x040079E6 RID: 31206
		[Token(Token = "0x40079E6")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<uint, GameObject> m_ThirdTabTipsDict;

		// Token: 0x040079E7 RID: 31207
		[Token(Token = "0x40079E7")]
		[FieldOffset(Offset = "0xB0")]
		private int m_ADWidth;

		// Token: 0x040079E8 RID: 31208
		[Token(Token = "0x40079E8")]
		[FieldOffset(Offset = "0xB4")]
		private int m_RightAreaWidth;

		// Token: 0x040079E9 RID: 31209
		[Token(Token = "0x40079E9")]
		[FieldOffset(Offset = "0xB8")]
		private List<StandardTabItemViewData> m_TabDataList;

		// Token: 0x040079EA RID: 31210
		[Token(Token = "0x40079EA")]
		[FieldOffset(Offset = "0xC0")]
		private UIStandardTabController m_TabCtrl;

		// Token: 0x0200140B RID: 5131
		[Token(Token = "0x200140B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC4F0", Offset = "0x10EC4F0")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x060054A0 RID: 21664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054A0")]
			[Address(RVA = "0x195F83C", Offset = "0x195F83C", VA = "0x7BBC15F83C")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x060054A1 RID: 21665 RVA: 0x00019410 File Offset: 0x00017610
			[Token(Token = "0x60054A1")]
			[Address(RVA = "0x19636F0", Offset = "0x19636F0", VA = "0x7BBC1636F0")]
			internal bool <ActivityGroupSelected>b__0(AdvertDesc e)
			{
				return default(bool);
			}

			// Token: 0x040079EB RID: 31211
			[Token(Token = "0x40079EB")]
			[FieldOffset(Offset = "0x10")]
			public ActivityGroupDesc desc;
		}

		// Token: 0x0200140C RID: 5132
		[Token(Token = "0x200140C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC500", Offset = "0x10EC500")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x060054A2 RID: 21666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054A2")]
			[Address(RVA = "0x1962148", Offset = "0x1962148", VA = "0x7BBC162148")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x060054A3 RID: 21667 RVA: 0x00019428 File Offset: 0x00017628
			[Token(Token = "0x60054A3")]
			[Address(RVA = "0x196379C", Offset = "0x196379C", VA = "0x7BBC16379C")]
			internal bool <SelectItem>b__0(ActivityGroupDesc e)
			{
				return default(bool);
			}

			// Token: 0x040079EC RID: 31212
			[Token(Token = "0x40079EC")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x0200140D RID: 5133
		[Token(Token = "0x200140D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC510", Offset = "0x10EC510")]
		private sealed class <>c__DisplayClass33_0
		{
			// Token: 0x060054A4 RID: 21668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054A4")]
			[Address(RVA = "0x1962E14", Offset = "0x1962E14", VA = "0x7BBC162E14")]
			public <>c__DisplayClass33_0()
			{
			}

			// Token: 0x060054A5 RID: 21669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054A5")]
			[Address(RVA = "0x19637D8", Offset = "0x19637D8", VA = "0x7BBC1637D8")]
			internal void <CreateThirdTabs>b__0()
			{
			}

			// Token: 0x040079ED RID: 31213
			[Token(Token = "0x40079ED")]
			[FieldOffset(Offset = "0x10")]
			public int tempIndex;

			// Token: 0x040079EE RID: 31214
			[Token(Token = "0x40079EE")]
			[FieldOffset(Offset = "0x18")]
			public UIActivityStandardController <>4__this;
		}

		// Token: 0x0200140E RID: 5134
		[Token(Token = "0x200140E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC520", Offset = "0x10EC520")]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x060054A6 RID: 21670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054A6")]
			[Address(RVA = "0x19632B8", Offset = "0x19632B8", VA = "0x7BBC1632B8")]
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x060054A7 RID: 21671 RVA: 0x00019440 File Offset: 0x00017640
			[Token(Token = "0x60054A7")]
			[Address(RVA = "0x196380C", Offset = "0x196380C", VA = "0x7BBC16380C")]
			internal bool <OpenLargeContent>b__0(AdvertDesc e)
			{
				return default(bool);
			}

			// Token: 0x060054A8 RID: 21672 RVA: 0x00019458 File Offset: 0x00017658
			[Token(Token = "0x60054A8")]
			[Address(RVA = "0x19638B8", Offset = "0x19638B8", VA = "0x7BBC1638B8")]
			internal bool <OpenLargeContent>b__1(AdvertDesc e)
			{
				return default(bool);
			}

			// Token: 0x040079EF RID: 31215
			[Token(Token = "0x40079EF")]
			[FieldOffset(Offset = "0x10")]
			public ActivityGroupDesc desc;
		}

		// Token: 0x0200140F RID: 5135
		[Token(Token = "0x200140F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC530", Offset = "0x10EC530")]
		private sealed class <>c__DisplayClass37_1
		{
			// Token: 0x060054A9 RID: 21673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054A9")]
			[Address(RVA = "0x19632C0", Offset = "0x19632C0", VA = "0x7BBC1632C0")]
			public <>c__DisplayClass37_1()
			{
			}

			// Token: 0x060054AA RID: 21674 RVA: 0x00019470 File Offset: 0x00017670
			[Token(Token = "0x60054AA")]
			[Address(RVA = "0x1963964", Offset = "0x1963964", VA = "0x7BBC163964")]
			internal bool <OpenLargeContent>b__2(AdvertDesc e)
			{
				return default(bool);
			}

			// Token: 0x040079F0 RID: 31216
			[Token(Token = "0x40079F0")]
			[FieldOffset(Offset = "0x10")]
			public ClientActivityDesc act;
		}

		// Token: 0x02001410 RID: 5136
		[Token(Token = "0x2001410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC540", Offset = "0x10EC540")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x060054AB RID: 21675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60054AB")]
			[Address(RVA = "0x196354C", Offset = "0x196354C", VA = "0x7BBC16354C")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x060054AC RID: 21676 RVA: 0x00019488 File Offset: 0x00017688
			[Token(Token = "0x60054AC")]
			[Address(RVA = "0x19639B0", Offset = "0x19639B0", VA = "0x7BBC1639B0")]
			internal bool <OnDataChanged>b__0(ClientActivityDesc temp)
			{
				return default(bool);
			}

			// Token: 0x040079F1 RID: 31217
			[Token(Token = "0x40079F1")]
			[FieldOffset(Offset = "0x10")]
			public uint activityId;
		}
	}
}
