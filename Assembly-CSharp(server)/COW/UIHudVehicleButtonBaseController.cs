using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200198B RID: 6539
	[Token(Token = "0x200198B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F683C", Offset = "0x10F683C")]
	internal abstract class UIHudVehicleButtonBaseController : UIHudButtonBaseController
	{
		// Token: 0x0600855F RID: 34143
		[Token(Token = "0x600855F")]
		protected abstract EControlMode ShowInControlMode();

		// Token: 0x06008560 RID: 34144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008560")]
		[Address(RVA = "0x15ED2B8", Offset = "0x15ED2B8", VA = "0x7BBBDED2B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008561 RID: 34145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008561")]
		[Address(RVA = "0x15EF424", Offset = "0x15EF424", VA = "0x7BBBDEF424", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008562 RID: 34146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008562")]
		[Address(RVA = "0x15EF4FC", Offset = "0x15EF4FC", VA = "0x7BBBDEF4FC", Slot = "18")]
		protected override void OnUIActiveGroupSwitch(ulong activeGroup)
		{
		}

		// Token: 0x06008563 RID: 34147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008563")]
		[Address(RVA = "0x15EF5FC", Offset = "0x15EF5FC", VA = "0x7BBBDEF5FC", Slot = "35")]
		protected virtual void RefreshVisibleWithControlMode(params object[] data)
		{
		}

		// Token: 0x06008564 RID: 34148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008564")]
		[Address(RVA = "0x15ED3E8", Offset = "0x15ED3E8", VA = "0x7BBBDED3E8")]
		protected UIHudVehicleButtonBaseController()
		{
		}
	}
}
