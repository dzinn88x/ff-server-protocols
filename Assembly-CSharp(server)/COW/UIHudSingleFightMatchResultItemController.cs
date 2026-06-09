using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015F8 RID: 5624
	[Token(Token = "0x20015F8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF7A4", Offset = "0x10EF7A4")]
	public class UIHudSingleFightMatchResultItemController : UIHudMatchResultItemBaseController
	{
		// Token: 0x06006448 RID: 25672 RVA: 0x0001CD28 File Offset: 0x0001AF28
		[Token(Token = "0x6006448")]
		[Address(RVA = "0x1666F40", Offset = "0x1666F40", VA = "0x7BBBE66F40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006449")]
		[Address(RVA = "0x1666F90", Offset = "0x1666F90", VA = "0x7BBBE66F90")]
		public UIHudSingleFightMatchResultItemController()
		{
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644A")]
		[Address(RVA = "0x1666F98", Offset = "0x1666F98", VA = "0x7BBBE66F98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644B")]
		[Address(RVA = "0x166717C", Offset = "0x166717C", VA = "0x7BBBE6717C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644C")]
		[Address(RVA = "0x1667290", Offset = "0x1667290", VA = "0x7BBBE67290", Slot = "34")]
		protected override void OnSetPlayerData(TeammateStats data)
		{
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644D")]
		[Address(RVA = "0x1667360", Offset = "0x1667360", VA = "0x7BBBE67360")]
		private void UpdatePlayerData(TeammateStats player)
		{
		}

		// Token: 0x040082D9 RID: 33497
		[Token(Token = "0x40082D9")]
		[FieldOffset(Offset = "0x100")]
		private UIHudSingleFightMatchResultItemView m_View;
	}
}
