using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001861 RID: 6241
	[Token(Token = "0x2001861")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3EB4", Offset = "0x10F3EB4")]
	public class UIHistoryRecordItemController : UIEasyListItemController
	{
		// Token: 0x06007AF7 RID: 31479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF7")]
		[Address(RVA = "0x1D5DDC4", Offset = "0x1D5DDC4", VA = "0x7BBC55DDC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x00021D68 File Offset: 0x0001FF68
		[Token(Token = "0x6007AF8")]
		[Address(RVA = "0x1D5DF9C", Offset = "0x1D5DF9C", VA = "0x7BBC55DF9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x00021D80 File Offset: 0x0001FF80
		[Token(Token = "0x6007AF9")]
		[Address(RVA = "0x1D5DFEC", Offset = "0x1D5DFEC", VA = "0x7BBC55DFEC")]
		private bool IsMatchInfo4v4(MatchRecordPersonal data)
		{
			return default(bool);
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFA")]
		[Address(RVA = "0x1D5E020", Offset = "0x1D5E020", VA = "0x7BBC55E020")]
		private void UpdateDelta(MatchRecordPersonal data)
		{
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFB")]
		[Address(RVA = "0x1D5E78C", Offset = "0x1D5E78C", VA = "0x7BBC55E78C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFC")]
		[Address(RVA = "0x1D5FAD0", Offset = "0x1D5FAD0", VA = "0x7BBC55FAD0", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFD")]
		[Address(RVA = "0x1D5FBE0", Offset = "0x1D5FBE0", VA = "0x7BBC55FBE0", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFE")]
		[Address(RVA = "0x1D5FC30", Offset = "0x1D5FC30", VA = "0x7BBC55FC30", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AFF")]
		[Address(RVA = "0x1D5FC80", Offset = "0x1D5FC80", VA = "0x7BBC55FC80")]
		public UIHistoryRecordItemController()
		{
		}

		// Token: 0x04008F80 RID: 36736
		[Token(Token = "0x4008F80")]
		[FieldOffset(Offset = "0x70")]
		private UIHistoryRecordItemView m_View;

		// Token: 0x04008F81 RID: 36737
		[Token(Token = "0x4008F81")]
		[FieldOffset(Offset = "0x78")]
		private MatchRecordPersonal m_RecordData;

		// Token: 0x04008F82 RID: 36738
		[Token(Token = "0x4008F82")]
		[FieldOffset(Offset = "0x80")]
		private List<GameObject> m_GroupHeadCount;

		// Token: 0x04008F83 RID: 36739
		[Token(Token = "0x4008F83")]
		private const string FIRST_STRING = "TXT_OB5_HISTORY_NO1";

		// Token: 0x04008F84 RID: 36740
		[Token(Token = "0x4008F84")]
		private const string TOP3_STRING = "TXT_OB5_HISTORY_TOP3";

		// Token: 0x04008F85 RID: 36741
		[Token(Token = "0x4008F85")]
		private const string TOP5_STRING = "TXT_OB5_HISTORY_TOP5";

		// Token: 0x04008F86 RID: 36742
		[Token(Token = "0x4008F86")]
		private const string TOP10_STRING = "TXT_OB5_HISTORY_TOP10";

		// Token: 0x04008F87 RID: 36743
		[Token(Token = "0x4008F87")]
		private const string Win_String = "T_26_YP_HISTORY_WIN";

		// Token: 0x04008F88 RID: 36744
		[Token(Token = "0x4008F88")]
		private const string Lose_string = "T_26_YP_HISTORY_LOSE";

		// Token: 0x04008F89 RID: 36745
		[Token(Token = "0x4008F89")]
		private const uint FIRST_COLOR = 4294949376U;

		// Token: 0x04008F8A RID: 36746
		[Token(Token = "0x4008F8A")]
		private const uint HIGHRANK_COLOR = 4294967295U;

		// Token: 0x04008F8B RID: 36747
		[Token(Token = "0x4008F8B")]
		public const string POSITIVE_DELTA_COLOR = "[62ffe3]";

		// Token: 0x04008F8C RID: 36748
		[Token(Token = "0x4008F8C")]
		public const string NEGATIVE_DELTA_COLOR = "[ff2a00]";

		// Token: 0x04008F8D RID: 36749
		[Token(Token = "0x4008F8D")]
		[FieldOffset(Offset = "0x88")]
		private Color colorbg1;

		// Token: 0x04008F8E RID: 36750
		[Token(Token = "0x4008F8E")]
		[FieldOffset(Offset = "0x98")]
		private Color colorbg2;
	}
}
