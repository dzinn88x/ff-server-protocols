using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017E5 RID: 6117
	[Token(Token = "0x20017E5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F300C", Offset = "0x10F300C")]
	public class UIGachaEnergyBuyBtnController : UIGachaBuyBtnController
	{
		// Token: 0x0600765C RID: 30300 RVA: 0x00020D00 File Offset: 0x0001EF00
		[Token(Token = "0x600765C")]
		[Address(RVA = "0x2161588", Offset = "0x2161588", VA = "0x7BBC961588")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765D")]
		[Address(RVA = "0x21615D8", Offset = "0x21615D8", VA = "0x7BBC9615D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765E")]
		[Address(RVA = "0x2161634", Offset = "0x2161634", VA = "0x7BBC961634", Slot = "28")]
		protected override void InitBuyBtnBaseView()
		{
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600765F")]
		[Address(RVA = "0x2161668", Offset = "0x2161668", VA = "0x7BBC961668")]
		public UIGachaEnergyBuyBtnController()
		{
		}

		// Token: 0x04008D3C RID: 36156
		[Token(Token = "0x4008D3C")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaEnergyBuyBtnView m_EnergyView;
	}
}
