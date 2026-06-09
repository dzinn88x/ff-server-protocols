using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020017BD RID: 6077
	[Token(Token = "0x20017BD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2A64", Offset = "0x10F2A64")]
	public class UIFirstChangeNamePopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007464 RID: 29796 RVA: 0x00020490 File Offset: 0x0001E690
		[Token(Token = "0x6007464")]
		[Address(RVA = "0x1DB6A48", Offset = "0x1DB6A48", VA = "0x7BBC5B6A48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007465")]
		[Address(RVA = "0x1DB6A98", Offset = "0x1DB6A98", VA = "0x7BBC5B6A98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007466")]
		[Address(RVA = "0x1DB6DD8", Offset = "0x1DB6DD8", VA = "0x7BBC5B6DD8")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007467")]
		[Address(RVA = "0x1DB724C", Offset = "0x1DB724C", VA = "0x7BBC5B724C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007468")]
		[Address(RVA = "0x1DB6F70", Offset = "0x1DB6F70", VA = "0x7BBC5B6F70")]
		private void OnInputChange()
		{
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x000204A8 File Offset: 0x0001E6A8
		[Token(Token = "0x6007469")]
		[Address(RVA = "0x1DB7300", Offset = "0x1DB7300", VA = "0x7BBC5B7300")]
		private bool IsNameValid(string name)
		{
			return default(bool);
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746A")]
		[Address(RVA = "0x1DB7368", Offset = "0x1DB7368", VA = "0x7BBC5B7368")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746B")]
		[Address(RVA = "0x1DB7660", Offset = "0x1DB7660", VA = "0x7BBC5B7660", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x000204C0 File Offset: 0x0001E6C0
		[Token(Token = "0x600746C")]
		[Address(RVA = "0x1DB7BE0", Offset = "0x1DB7BE0", VA = "0x7BBC5B7BE0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746D")]
		[Address(RVA = "0x1DB7C24", Offset = "0x1DB7C24", VA = "0x7BBC5B7C24")]
		private void OnChangeRandomName()
		{
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600746E")]
		[Address(RVA = "0x1DB78C0", Offset = "0x1DB78C0", VA = "0x7BBC5B78C0")]
		private void NameAddSuffix()
		{
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x000204D8 File Offset: 0x0001E6D8
		[Token(Token = "0x600746F")]
		[Address(RVA = "0x1DB7F54", Offset = "0x1DB7F54", VA = "0x7BBC5B7F54", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x000204F0 File Offset: 0x0001E6F0
		[Token(Token = "0x6007470")]
		[Address(RVA = "0x1DB7F5C", Offset = "0x1DB7F5C", VA = "0x7BBC5B7F5C", Slot = "30")]
		public override int GlassDelay()
		{
			return 0;
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007471")]
		[Address(RVA = "0x1DB7F64", Offset = "0x1DB7F64", VA = "0x7BBC5B7F64")]
		public UIFirstChangeNamePopupWindowController()
		{
		}

		// Token: 0x04008C44 RID: 35908
		[Token(Token = "0x4008C44")]
		[FieldOffset(Offset = "0x98")]
		private UIFirstChangeNamePopupWindowView m_View;

		// Token: 0x04008C45 RID: 35909
		[Token(Token = "0x4008C45")]
		private const uint DEFUALT_COLOR = 4294967295U;

		// Token: 0x04008C46 RID: 35910
		[Token(Token = "0x4008C46")]
		private const uint GREY_COLOR = 1987475199U;

		// Token: 0x04008C47 RID: 35911
		[Token(Token = "0x4008C47")]
		[FieldOffset(Offset = "0xA0")]
		private LoginRes m_UserData;

		// Token: 0x04008C48 RID: 35912
		[Token(Token = "0x4008C48")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_HasRequestedRename;

		// Token: 0x04008C49 RID: 35913
		[Token(Token = "0x4008C49")]
		[FieldOffset(Offset = "0xB0")]
		private Animation m_BtnChangeAnimation;

		// Token: 0x04008C4A RID: 35914
		[Token(Token = "0x4008C4A")]
		[FieldOffset(Offset = "0xB8")]
		private List<NickNamePreListData> m_nickNameList;
	}
}
