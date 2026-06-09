using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015F5 RID: 5621
	[Token(Token = "0x20015F5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF724", Offset = "0x10EF724")]
	public class UIHudNormalMatchResultItemController : UIHudMatchResultItemBaseController
	{
		// Token: 0x06006430 RID: 25648 RVA: 0x0001CC98 File Offset: 0x0001AE98
		[Token(Token = "0x6006430")]
		[Address(RVA = "0x17BA188", Offset = "0x17BA188", VA = "0x7BBBFBA188")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006431")]
		[Address(RVA = "0x17BA1D8", Offset = "0x17BA1D8", VA = "0x7BBBFBA1D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006432")]
		[Address(RVA = "0x17BA3E4", Offset = "0x17BA3E4", VA = "0x7BBBFBA3E4", Slot = "34")]
		protected override void OnSetPlayerData(TeammateStats data)
		{
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006433")]
		[Address(RVA = "0x17BA49C", Offset = "0x17BA49C", VA = "0x7BBBFBA49C")]
		private void UpdatePlayerData(TeammateStats player)
		{
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006434")]
		[Address(RVA = "0x17BA894", Offset = "0x17BA894", VA = "0x7BBBFBA894")]
		public UIHudNormalMatchResultItemController()
		{
		}

		// Token: 0x040082D1 RID: 33489
		[Token(Token = "0x40082D1")]
		[FieldOffset(Offset = "0x100")]
		private UIHudNormalMatchResultItemView m_View;
	}
}
