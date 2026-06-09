using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200191B RID: 6427
	[Token(Token = "0x200191B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F589C", Offset = "0x10F589C")]
	internal class UIHudNameRedEnvelopeOwnerController : UIHudNameBaseController
	{
		// Token: 0x060081AC RID: 33196 RVA: 0x00023568 File Offset: 0x00021768
		[Token(Token = "0x60081AC")]
		[Address(RVA = "0x17B7AB8", Offset = "0x17B7AB8", VA = "0x7BBBFB7AB8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081AD")]
		[Address(RVA = "0x17B7B08", Offset = "0x17B7B08", VA = "0x7BBBFB7B08", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081AE")]
		[Address(RVA = "0x17B7B68", Offset = "0x17B7B68", VA = "0x7BBBFB7B68")]
		public void BindPlayer(Player owner)
		{
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x00023580 File Offset: 0x00021780
		[Token(Token = "0x60081AF")]
		[Address(RVA = "0x17B7C58", Offset = "0x17B7C58", VA = "0x7BBBFB7C58", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x00023598 File Offset: 0x00021798
		[Token(Token = "0x60081B0")]
		[Address(RVA = "0x17B7DAC", Offset = "0x17B7DAC", VA = "0x7BBBFB7DAC", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081B1")]
		[Address(RVA = "0x17B7DB4", Offset = "0x17B7DB4", VA = "0x7BBBFB7DB4")]
		public UIHudNameRedEnvelopeOwnerController()
		{
		}

		// Token: 0x0400934C RID: 37708
		[Token(Token = "0x400934C")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudNameRedEnvelopeOwnerView m_View;

		// Token: 0x0400934D RID: 37709
		[Token(Token = "0x400934D")]
		[FieldOffset(Offset = "0xB0")]
		private Player m_Owner;
	}
}
