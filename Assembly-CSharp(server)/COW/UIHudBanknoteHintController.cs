using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001874 RID: 6260
	[Token(Token = "0x2001874")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F41F4", Offset = "0x10F41F4")]
	public class UIHudBanknoteHintController : UIBaseController
	{
		// Token: 0x06007BA3 RID: 31651 RVA: 0x00021F90 File Offset: 0x00020190
		[Token(Token = "0x6007BA3")]
		[Address(RVA = "0x188BDF4", Offset = "0x188BDF4", VA = "0x7BBC08BDF4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA4")]
		[Address(RVA = "0x188BE44", Offset = "0x188BE44", VA = "0x7BBC08BE44", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA5")]
		[Address(RVA = "0x188BF3C", Offset = "0x188BF3C", VA = "0x7BBC08BF3C")]
		private void LocalBeginTryControl(object[] data)
		{
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA6")]
		[Address(RVA = "0x188C058", Offset = "0x188C058", VA = "0x7BBC08C058")]
		private void StopTryingControlCountDown()
		{
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA7")]
		[Address(RVA = "0x188C06C", Offset = "0x188C06C", VA = "0x7BBC08C06C")]
		private void Update()
		{
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA8")]
		[Address(RVA = "0x188C284", Offset = "0x188C284", VA = "0x7BBC08C284")]
		public UIHudBanknoteHintController()
		{
		}

		// Token: 0x0400900D RID: 36877
		[Token(Token = "0x400900D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBanknoteHintView m_View;

		// Token: 0x0400900E RID: 36878
		[Token(Token = "0x400900E")]
		[FieldOffset(Offset = "0x60")]
		private float m_ControlTargetTime;

		// Token: 0x0400900F RID: 36879
		[Token(Token = "0x400900F")]
		[FieldOffset(Offset = "0x64")]
		private int m_LastSecond;

		// Token: 0x04009010 RID: 36880
		[Token(Token = "0x4009010")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_HintText;
	}
}
