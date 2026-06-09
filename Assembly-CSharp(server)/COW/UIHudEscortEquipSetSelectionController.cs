using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018B7 RID: 6327
	[Token(Token = "0x20018B7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4A74", Offset = "0x10F4A74")]
	public class UIHudEscortEquipSetSelectionController : UIBaseController
	{
		// Token: 0x06007DD8 RID: 32216 RVA: 0x000227A0 File Offset: 0x000209A0
		[Token(Token = "0x6007DD8")]
		[Address(RVA = "0x1C060C4", Offset = "0x1C060C4", VA = "0x7BBC4060C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DD9")]
		[Address(RVA = "0x1C06114", Offset = "0x1C06114", VA = "0x7BBC406114", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DDA")]
		[Address(RVA = "0x1C06C6C", Offset = "0x1C06C6C", VA = "0x7BBC406C6C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DDB")]
		[Address(RVA = "0x1C06D8C", Offset = "0x1C06D8C", VA = "0x7BBC406D8C")]
		private void OnRefreshEquip(params object[] param)
		{
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DDC")]
		[Address(RVA = "0x1C06D90", Offset = "0x1C06D90", VA = "0x7BBC406D90")]
		private void OnUpdateEquip(params object[] param)
		{
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x000227B8 File Offset: 0x000209B8
		[Token(Token = "0x6007DDD")]
		[Address(RVA = "0x1C069F4", Offset = "0x1C069F4", VA = "0x7BBC4069F4")]
		private int GetEquipSetUIIndex(uint equipSetID)
		{
			return 0;
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DDE")]
		[Address(RVA = "0x1C06964", Offset = "0x1C06964", VA = "0x7BBC406964")]
		public void SetStartState()
		{
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DDF")]
		[Address(RVA = "0x1C06B4C", Offset = "0x1C06B4C", VA = "0x7BBC406B4C")]
		private void OnSelectItem(int index)
		{
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE0")]
		[Address(RVA = "0x1C06900", Offset = "0x1C06900", VA = "0x7BBC406900")]
		private void SetConfirmButtonState(bool canclick)
		{
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE1")]
		[Address(RVA = "0x1C06D94", Offset = "0x1C06D94", VA = "0x7BBC406D94")]
		private void OnConfirm()
		{
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE2")]
		[Address(RVA = "0x1C068FC", Offset = "0x1C068FC", VA = "0x7BBC4068FC")]
		private void RequestEquipInfo()
		{
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE3")]
		[Address(RVA = "0x1C07038", Offset = "0x1C07038", VA = "0x7BBC407038")]
		private void Update()
		{
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE4")]
		[Address(RVA = "0x1C07094", Offset = "0x1C07094", VA = "0x7BBC407094", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DE5")]
		[Address(RVA = "0x1C0709C", Offset = "0x1C0709C", VA = "0x7BBC40709C")]
		public UIHudEscortEquipSetSelectionController()
		{
		}

		// Token: 0x04009145 RID: 37189
		[Token(Token = "0x4009145")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortEquipSetSelectionView m_View;

		// Token: 0x04009146 RID: 37190
		[Token(Token = "0x4009146")]
		[FieldOffset(Offset = "0x60")]
		private UIEscortEquipSetItemController m_SelectSetUI;

		// Token: 0x04009147 RID: 37191
		[Token(Token = "0x4009147")]
		[FieldOffset(Offset = "0x68")]
		private List<UIEscortEquipSetItemController> m_SetItemUIs;

		// Token: 0x04009148 RID: 37192
		[Token(Token = "0x4009148")]
		[FieldOffset(Offset = "0x70")]
		private UITimeLabelHelper m_EndTime;

		// Token: 0x04009149 RID: 37193
		[Token(Token = "0x4009149")]
		private const int m_MaxItemCout = 6;
	}
}
