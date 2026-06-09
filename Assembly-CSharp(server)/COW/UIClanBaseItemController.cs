using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200171B RID: 5915
	[Token(Token = "0x200171B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1814", Offset = "0x10F1814")]
	internal class UIClanBaseItemController : UIEasyListItemController
	{
		// Token: 0x06006E53 RID: 28243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E53")]
		[Address(RVA = "0x1CEC0E0", Offset = "0x1CEC0E0", VA = "0x7BBC4EC0E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E54")]
		[Address(RVA = "0x1CEC34C", Offset = "0x1CEC34C", VA = "0x7BBC4EC34C")]
		private void OnBtnShowDetailClick()
		{
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E55")]
		[Address(RVA = "0x1CED260", Offset = "0x1CED260", VA = "0x7BBC4ED260", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E56")]
		[Address(RVA = "0x1CED268", Offset = "0x1CED268", VA = "0x7BBC4ED268")]
		private void OnPopMenuClick(object obj)
		{
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E57")]
		[Address(RVA = "0x1CEDAC0", Offset = "0x1CEDAC0", VA = "0x7BBC4EDAC0", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E58")]
		[Address(RVA = "0x1CEDB00", Offset = "0x1CEDB00", VA = "0x7BBC4EDB00", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E59")]
		[Address(RVA = "0x1CEDB40", Offset = "0x1CEDB40", VA = "0x7BBC4EDB40")]
		public void SetItemSelect(bool isSelected)
		{
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5A")]
		[Address(RVA = "0x1CEDB78", Offset = "0x1CEDB78", VA = "0x7BBC4EDB78")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5B")]
		[Address(RVA = "0x1CEDC70", Offset = "0x1CEDC70", VA = "0x7BBC4EDC70")]
		private void OnRefuseClick()
		{
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5C")]
		[Address(RVA = "0x1CEDD68", Offset = "0x1CEDD68", VA = "0x7BBC4EDD68", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x0001F110 File Offset: 0x0001D310
		[Token(Token = "0x6006E5D")]
		[Address(RVA = "0x1CEE590", Offset = "0x1CEE590", VA = "0x7BBC4EE590")]
		private float GetAlpha(EPresence.AccountPresence status)
		{
			return 0f;
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5E")]
		[Address(RVA = "0x1CEE5A8", Offset = "0x1CEE5A8", VA = "0x7BBC4EE5A8")]
		public UIClanBaseItemController()
		{
		}

		// Token: 0x040088F4 RID: 35060
		[Token(Token = "0x40088F4")]
		[FieldOffset(Offset = "0x70")]
		protected UIButton BtnShowDeatil;

		// Token: 0x040088F5 RID: 35061
		[Token(Token = "0x40088F5")]
		[FieldOffset(Offset = "0x78")]
		protected UISprite SelectLine;

		// Token: 0x040088F6 RID: 35062
		[Token(Token = "0x40088F6")]
		[FieldOffset(Offset = "0x80")]
		protected UIWidget ClanItemInfoContainer;

		// Token: 0x040088F7 RID: 35063
		[Token(Token = "0x40088F7")]
		[FieldOffset(Offset = "0x88")]
		protected UILabel ClanPosition;

		// Token: 0x040088F8 RID: 35064
		[Token(Token = "0x40088F8")]
		[FieldOffset(Offset = "0x90")]
		protected UILabel HonorPointLabel;

		// Token: 0x040088F9 RID: 35065
		[Token(Token = "0x40088F9")]
		[FieldOffset(Offset = "0x98")]
		protected UILabel AccountState_Online;

		// Token: 0x040088FA RID: 35066
		[Token(Token = "0x40088FA")]
		[FieldOffset(Offset = "0xA0")]
		protected UILabel AccountState_Offline;

		// Token: 0x040088FB RID: 35067
		[Token(Token = "0x40088FB")]
		[FieldOffset(Offset = "0xA8")]
		protected UILabel AccountState_InGame;

		// Token: 0x040088FC RID: 35068
		[Token(Token = "0x40088FC")]
		[FieldOffset(Offset = "0xB0")]
		protected Transform AccountInfoContainer;

		// Token: 0x040088FD RID: 35069
		[Token(Token = "0x40088FD")]
		[FieldOffset(Offset = "0xB8")]
		protected GameObject ApplyBtnGroup;

		// Token: 0x040088FE RID: 35070
		[Token(Token = "0x40088FE")]
		[FieldOffset(Offset = "0xC0")]
		protected UIButton BtnComfirm;

		// Token: 0x040088FF RID: 35071
		[Token(Token = "0x40088FF")]
		[FieldOffset(Offset = "0xC8")]
		protected UIButton BtnRefuse;

		// Token: 0x04008900 RID: 35072
		[Token(Token = "0x4008900")]
		[FieldOffset(Offset = "0xD0")]
		protected object m_Data;

		// Token: 0x04008901 RID: 35073
		[Token(Token = "0x4008901")]
		[FieldOffset(Offset = "0xD8")]
		protected UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x04008902 RID: 35074
		[Token(Token = "0x4008902")]
		[FieldOffset(Offset = "0xE0")]
		protected uint COLOR_ONLINE;

		// Token: 0x04008903 RID: 35075
		[Token(Token = "0x4008903")]
		[FieldOffset(Offset = "0xE4")]
		protected uint COLOR_OFFLINE;

		// Token: 0x0200171C RID: 5916
		[Token(Token = "0x200171C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F184C", Offset = "0x10F184C")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06006E5F RID: 28255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E5F")]
			[Address(RVA = "0x1CEDAB8", Offset = "0x1CEDAB8", VA = "0x7BBC4EDAB8")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06006E60 RID: 28256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E60")]
			[Address(RVA = "0x1CEE5C0", Offset = "0x1CEE5C0", VA = "0x7BBC4EE5C0")]
			internal void <OnPopMenuClick>b__0()
			{
			}

			// Token: 0x04008904 RID: 35076
			[Token(Token = "0x4008904")]
			[FieldOffset(Offset = "0x10")]
			public EClanOperation op;

			// Token: 0x04008905 RID: 35077
			[Token(Token = "0x4008905")]
			[FieldOffset(Offset = "0x18")]
			public ClanMember member_data;
		}
	}
}
