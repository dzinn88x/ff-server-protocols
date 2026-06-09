using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200145F RID: 5215
	[Token(Token = "0x200145F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECBF8", Offset = "0x10ECBF8")]
	public class BountyRepairingProgressController : UIBaseController
	{
		// Token: 0x060057AC RID: 22444 RVA: 0x00019EF0 File Offset: 0x000180F0
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x14E5110", Offset = "0x14E5110", VA = "0x7BBBCE5110")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x14E5160", Offset = "0x14E5160", VA = "0x7BBBCE5160", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x14E5328", Offset = "0x14E5328", VA = "0x7BBBCE5328")]
		private void OnProgressCome(params object[] param)
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x14E5558", Offset = "0x14E5558", VA = "0x7BBBCE5558")]
		public BountyRepairingProgressController()
		{
		}

		// Token: 0x04007BDA RID: 31706
		[Token(Token = "0x4007BDA")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDBountyRepairProgressView m_view;
	}
}
