using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018CD RID: 6349
	[Token(Token = "0x20018CD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4E14", Offset = "0x10F4E14")]
	internal abstract class UIHudGetOnVehicleController : UIHudButtonBaseController
	{
		// Token: 0x06007E7A RID: 32378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E7A")]
		[Address(RVA = "0x1C16E78", Offset = "0x1C16E78", VA = "0x7BBC416E78", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E7B")]
		[Address(RVA = "0x1C1741C", Offset = "0x1C1741C", VA = "0x7BBC41741C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E7C")]
		[Address(RVA = "0x1C170B0", Offset = "0x1C170B0", VA = "0x7BBC4170B0", Slot = "34")]
		protected virtual void OnActionEnter(params object[] param)
		{
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x00022938 File Offset: 0x00020B38
		[Token(Token = "0x6007E7D")]
		[Address(RVA = "0x1C17548", Offset = "0x1C17548", VA = "0x7BBC417548", Slot = "35")]
		protected virtual bool ShouldShow(bool driverEmpty, bool passengerEmpty)
		{
			return default(bool);
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E7E")]
		[Address(RVA = "0x1C17550", Offset = "0x1C17550", VA = "0x7BBC417550")]
		protected void OnActionEnd(params object[] param)
		{
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E7F")]
		[Address(RVA = "0x1C171AC", Offset = "0x1C171AC", VA = "0x7BBC4171AC")]
		protected UIHudGetOnVehicleController()
		{
		}
	}
}
