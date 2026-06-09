using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001633 RID: 5683
	[Token(Token = "0x2001633")]
	internal class UIPVEWeaponBtnController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006657 RID: 26199 RVA: 0x0001D358 File Offset: 0x0001B558
		[Token(Token = "0x6006657")]
		[Address(RVA = "0x16E6EA0", Offset = "0x16E6EA0", VA = "0x7BBBEE6EA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006658")]
		[Address(RVA = "0x16E6EF0", Offset = "0x16E6EF0", VA = "0x7BBBEE6EF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006659")]
		[Address(RVA = "0x16E71B0", Offset = "0x16E71B0", VA = "0x7BBBEE71B0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665A")]
		[Address(RVA = "0x16E70B4", Offset = "0x16E70B4", VA = "0x7BBBEE70B4")]
		private void RefreshPrimaryWeapon(uint itemId)
		{
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665B")]
		[Address(RVA = "0x16E7284", Offset = "0x16E7284", VA = "0x7BBBEE7284")]
		private void OnWeaponBtnClick()
		{
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665C")]
		[Address(RVA = "0x16E7374", Offset = "0x16E7374", VA = "0x7BBBEE7374", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x0001D370 File Offset: 0x0001B570
		[Token(Token = "0x600665D")]
		[Address(RVA = "0x16E740C", Offset = "0x16E740C", VA = "0x7BBBEE740C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600665E")]
		[Address(RVA = "0x16E7450", Offset = "0x16E7450", VA = "0x7BBBEE7450")]
		public UIPVEWeaponBtnController()
		{
		}

		// Token: 0x0400841F RID: 33823
		[Token(Token = "0x400841F")]
		[FieldOffset(Offset = "0x58")]
		private UIPVEWeaponBtnView m_View;

		// Token: 0x04008420 RID: 33824
		[Token(Token = "0x4008420")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPVE m_ModelPVE;
	}
}
