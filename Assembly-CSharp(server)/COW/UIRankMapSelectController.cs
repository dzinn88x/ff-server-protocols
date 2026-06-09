using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B3E RID: 6974
	[Token(Token = "0x2001B3E")]
	public class UIRankMapSelectController : UIBaseController, IEasyList
	{
		// Token: 0x060095BD RID: 38333 RVA: 0x00027978 File Offset: 0x00025B78
		[Token(Token = "0x60095BD")]
		[Address(RVA = "0x1E0C758", Offset = "0x1E0C758", VA = "0x7BBC60C758")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095BE")]
		[Address(RVA = "0x1E0C7A8", Offset = "0x1E0C7A8", VA = "0x7BBC60C7A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095BF")]
		[Address(RVA = "0x1E0CA38", Offset = "0x1E0CA38", VA = "0x7BBC60CA38", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C0")]
		[Address(RVA = "0x1E0CBAC", Offset = "0x1E0CBAC", VA = "0x7BBC60CBAC")]
		public void SetViewData()
		{
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C1")]
		[Address(RVA = "0x1E0E2EC", Offset = "0x1E0E2EC", VA = "0x7BBC60E2EC")]
		private void ShowMapItemAnim()
		{
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C2")]
		[Address(RVA = "0x1E0E81C", Offset = "0x1E0E81C", VA = "0x7BBC60E81C")]
		private void ClearDelayCalls()
		{
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C3")]
		[Address(RVA = "0x1E0E97C", Offset = "0x1E0E97C", VA = "0x7BBC60E97C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C4")]
		[Address(RVA = "0x1E0EBD4", Offset = "0x1E0EBD4", VA = "0x7BBC60EBD4")]
		private void OnLadderMapSelectChanged(params object[] param)
		{
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C5")]
		[Address(RVA = "0x1E0ECF0", Offset = "0x1E0ECF0", VA = "0x7BBC60ECF0")]
		private void OnLadderMapSelectRefresh(params object[] param)
		{
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C6")]
		[Address(RVA = "0x1E0DA10", Offset = "0x1E0DA10", VA = "0x7BBC60DA10")]
		private void DataChanged()
		{
		}

		// Token: 0x060095C7 RID: 38343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C7")]
		[Address(RVA = "0x1E0D794", Offset = "0x1E0D794", VA = "0x7BBC60D794")]
		private void RefreshList(List<MapOpeningInfo> mapList, bool keep_page = false)
		{
		}

		// Token: 0x060095C8 RID: 38344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60095C8")]
		[Address(RVA = "0x1E0EEC0", Offset = "0x1E0EEC0", VA = "0x7BBC60EEC0", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095C9")]
		[Address(RVA = "0x1E0EF54", Offset = "0x1E0EF54", VA = "0x7BBC60EF54", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095CA")]
		[Address(RVA = "0x1E0EF84", Offset = "0x1E0EF84", VA = "0x7BBC60EF84")]
		private void OnConfirmButtonClick()
		{
		}

		// Token: 0x060095CB RID: 38347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095CB")]
		[Address(RVA = "0x1E0F30C", Offset = "0x1E0F30C", VA = "0x7BBC60F30C")]
		private void OnCommonGuideChanged(params object[] data)
		{
		}

		// Token: 0x060095CC RID: 38348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095CC")]
		[Address(RVA = "0x1E0F428", Offset = "0x1E0F428", VA = "0x7BBC60F428")]
		public UIRankMapSelectController()
		{
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095CD")]
		[Address(RVA = "0x1E0F4E8", Offset = "0x1E0F4E8", VA = "0x7BBC60F4E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C90", Offset = "0x1144C90")]
		private void <ShowMapItemAnim>b__10_1()
		{
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095CE")]
		[Address(RVA = "0x1E0F52C", Offset = "0x1E0F52C", VA = "0x7BBC60F52C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144CA0", Offset = "0x1144CA0")]
		private void <OnVisibilityChanged>b__12_0()
		{
		}

		// Token: 0x04009EC2 RID: 40642
		[Token(Token = "0x4009EC2")]
		[FieldOffset(Offset = "0x58")]
		private UIRankMapSelectView m_View;

		// Token: 0x04009EC3 RID: 40643
		[Token(Token = "0x4009EC3")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLadderMatch m_Model;

		// Token: 0x04009EC4 RID: 40644
		[Token(Token = "0x4009EC4")]
		[FieldOffset(Offset = "0x68")]
		private string m_RankKey;

		// Token: 0x04009EC5 RID: 40645
		[Token(Token = "0x4009EC5")]
		[FieldOffset(Offset = "0x70")]
		private List<UICommonGuideController> m_GuideController;

		// Token: 0x04009EC6 RID: 40646
		[Token(Token = "0x4009EC6")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, bool> m_MapSelectDictory;

		// Token: 0x04009EC7 RID: 40647
		[Token(Token = "0x4009EC7")]
		[FieldOffset(Offset = "0x80")]
		private List<uint> m_AnimDelayCalls;

		// Token: 0x02001B3F RID: 6975
		[Token(Token = "0x2001B3F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9904", Offset = "0x10F9904")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060095CF RID: 38351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095CF")]
			[Address(RVA = "0x1E0D784", Offset = "0x1E0D784", VA = "0x7BBC60D784")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x04009EC8 RID: 40648
			[Token(Token = "0x4009EC8")]
			[FieldOffset(Offset = "0x10")]
			public List<uint> keys;
		}

		// Token: 0x02001B40 RID: 6976
		[Token(Token = "0x2001B40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9914", Offset = "0x10F9914")]
		private sealed class <>c__DisplayClass8_1
		{
			// Token: 0x060095D0 RID: 38352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D0")]
			[Address(RVA = "0x1E0D78C", Offset = "0x1E0D78C", VA = "0x7BBC60D78C")]
			public <>c__DisplayClass8_1()
			{
			}

			// Token: 0x060095D1 RID: 38353 RVA: 0x00027990 File Offset: 0x00025B90
			[Token(Token = "0x60095D1")]
			[Address(RVA = "0x1E0F78C", Offset = "0x1E0F78C", VA = "0x7BBC60F78C")]
			internal bool <SetViewData>b__1(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x04009EC9 RID: 40649
			[Token(Token = "0x4009EC9")]
			[FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x04009ECA RID: 40650
			[Token(Token = "0x4009ECA")]
			[FieldOffset(Offset = "0x18")]
			public UIRankMapSelectController.<>c__DisplayClass8_0 CS$<>8__locals1;
		}

		// Token: 0x02001B41 RID: 6977
		[Token(Token = "0x2001B41")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9924", Offset = "0x10F9924")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060095D3 RID: 38355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D3")]
			[Address(RVA = "0x1E0F628", Offset = "0x1E0F628", VA = "0x7BBC60F628")]
			public <>c()
			{
			}

			// Token: 0x060095D4 RID: 38356 RVA: 0x000279A8 File Offset: 0x00025BA8
			[Token(Token = "0x60095D4")]
			[Address(RVA = "0x1E0F630", Offset = "0x1E0F630", VA = "0x7BBC60F630")]
			internal bool <SetViewData>b__8_0(MapOpeningInfo x)
			{
				return default(bool);
			}

			// Token: 0x060095D5 RID: 38357 RVA: 0x000279C0 File Offset: 0x00025BC0
			[Token(Token = "0x60095D5")]
			[Address(RVA = "0x1E0F664", Offset = "0x1E0F664", VA = "0x7BBC60F664")]
			internal int <ShowMapItemAnim>b__10_0(UIRankMapSelectItemController x, UIRankMapSelectItemController y)
			{
				return 0;
			}

			// Token: 0x04009ECB RID: 40651
			[Token(Token = "0x4009ECB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIRankMapSelectController.<>c <>9;

			// Token: 0x04009ECC RID: 40652
			[Token(Token = "0x4009ECC")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<MapOpeningInfo> <>9__8_0;

			// Token: 0x04009ECD RID: 40653
			[Token(Token = "0x4009ECD")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<UIRankMapSelectItemController> <>9__10_0;
		}

		// Token: 0x02001B42 RID: 6978
		[Token(Token = "0x2001B42")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F9934", Offset = "0x10F9934")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x060095D6 RID: 38358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D6")]
			[Address(RVA = "0x1E0E814", Offset = "0x1E0E814", VA = "0x7BBC60E814")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x060095D7 RID: 38359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60095D7")]
			[Address(RVA = "0x1E0F6D4", Offset = "0x1E0F6D4", VA = "0x7BBC60F6D4")]
			internal void <ShowMapItemAnim>b__2()
			{
			}

			// Token: 0x04009ECE RID: 40654
			[Token(Token = "0x4009ECE")]
			[FieldOffset(Offset = "0x10")]
			public UIRankMapSelectItemController item;
		}
	}
}
