using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001682 RID: 5762
	[Token(Token = "0x2001682")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0444", Offset = "0x10F0444")]
	public class UIHudFerrisWheelTakePhotoController : UIBaseController
	{
		// Token: 0x060068A6 RID: 26790 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
		[Token(Token = "0x60068A6")]
		[Address(RVA = "0x1C0BBC8", Offset = "0x1C0BBC8", VA = "0x7BBC40BBC8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A7")]
		[Address(RVA = "0x1C0BC18", Offset = "0x1C0BC18", VA = "0x7BBC40BC18", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A8")]
		[Address(RVA = "0x1C0BCFC", Offset = "0x1C0BCFC", VA = "0x7BBC40BCFC")]
		private void TakePhoto()
		{
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A9")]
		[Address(RVA = "0x1C0BE98", Offset = "0x1C0BE98", VA = "0x7BBC40BE98", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AA")]
		[Address(RVA = "0x1C0BF48", Offset = "0x1C0BF48", VA = "0x7BBC40BF48", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x060068AB RID: 26795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AB")]
		[Address(RVA = "0x1C0BFD8", Offset = "0x1C0BFD8", VA = "0x7BBC40BFD8")]
		public UIHudFerrisWheelTakePhotoController()
		{
		}

		// Token: 0x04008555 RID: 34133
		[Token(Token = "0x4008555")]
		[FieldOffset(Offset = "0x58")]
		private UIHudFerrisWheelTakePhotoView m_View;

		// Token: 0x04008556 RID: 34134
		[Token(Token = "0x4008556")]
		[FieldOffset(Offset = "0x60")]
		private ulong m_PreUIGroup;
	}
}
