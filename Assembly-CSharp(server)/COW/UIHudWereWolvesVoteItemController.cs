using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019A4 RID: 6564
	[Token(Token = "0x20019A4")]
	public class UIHudWereWolvesVoteItemController : UIEasyListItemController
	{
		// Token: 0x06008667 RID: 34407 RVA: 0x00024618 File Offset: 0x00022818
		[Token(Token = "0x6008667")]
		[Address(RVA = "0x1D1C6C0", Offset = "0x1D1C6C0", VA = "0x7BBC51C6C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008668")]
		[Address(RVA = "0x1D1C710", Offset = "0x1D1C710", VA = "0x7BBC51C710", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008669")]
		[Address(RVA = "0x1D1CA60", Offset = "0x1D1CA60", VA = "0x7BBC51CA60", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600866A RID: 34410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600866A")]
		[Address(RVA = "0x1D1CC7C", Offset = "0x1D1CC7C", VA = "0x7BBC51CC7C", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600866B")]
		[Address(RVA = "0x1D1CDF4", Offset = "0x1D1CDF4", VA = "0x7BBC51CDF4", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600866C")]
		[Address(RVA = "0x1D1CFA0", Offset = "0x1D1CFA0", VA = "0x7BBC51CFA0")]
		private void QuickChatBtnClick()
		{
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600866D")]
		[Address(RVA = "0x1D1D1B8", Offset = "0x1D1D1B8", VA = "0x7BBC51D1B8")]
		private void OnVoteSelectChanged(params object[] data)
		{
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600866E")]
		[Address(RVA = "0x1D1D1BC", Offset = "0x1D1D1BC", VA = "0x7BBC51D1BC")]
		private void OnPlayerRoleChange(params object[] data)
		{
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600866F")]
		[Address(RVA = "0x1D1D380", Offset = "0x1D1D380", VA = "0x7BBC51D380", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008670")]
		[Address(RVA = "0x1D1E310", Offset = "0x1D1E310", VA = "0x7BBC51E310")]
		private void OnMuteStateChange(params object[] data)
		{
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008671")]
		[Address(RVA = "0x1D1E480", Offset = "0x1D1E480", VA = "0x7BBC51E480")]
		private void OnPlayerVoiceStateChange(params object[] data)
		{
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008672")]
		[Address(RVA = "0x1D1E5EC", Offset = "0x1D1E5EC", VA = "0x7BBC51E5EC")]
		private void OnLocalPlayerVoiceStateChange(params object[] data)
		{
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008673")]
		[Address(RVA = "0x1D1CE1C", Offset = "0x1D1CE1C", VA = "0x7BBC51CE1C")]
		public void RefreshSelectHighlight()
		{
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008674")]
		[Address(RVA = "0x1D1E6E0", Offset = "0x1D1E6E0", VA = "0x7BBC51E6E0")]
		public UIHudWereWolvesVoteItemController()
		{
		}

		// Token: 0x04009583 RID: 38275
		[Token(Token = "0x4009583")]
		[FieldOffset(Offset = "0x70")]
		private UIHudWereWolvesVoteItemView m_View;

		// Token: 0x04009584 RID: 38276
		[Token(Token = "0x4009584")]
		[FieldOffset(Offset = "0x78")]
		private zCUI\u0081}O m_info;

		// Token: 0x04009585 RID: 38277
		[Token(Token = "0x4009585")]
		[FieldOffset(Offset = "0x80")]
		private List<UIHudWereWolvesVoteIndexController> m_IdxChildList;

		// Token: 0x04009586 RID: 38278
		[Token(Token = "0x4009586")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_userId;
	}
}
