using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001687 RID: 5767
	[Token(Token = "0x2001687")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0524", Offset = "0x10F0524")]
	public class UIHudPortalMaskController : UIBaseController
	{
		// Token: 0x060068C7 RID: 26823 RVA: 0x0001DB08 File Offset: 0x0001BD08
		[Token(Token = "0x60068C7")]
		[Address(RVA = "0x1D8573C", Offset = "0x1D8573C", VA = "0x7BBC58573C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C8")]
		[Address(RVA = "0x1D8578C", Offset = "0x1D8578C", VA = "0x7BBC58578C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068C9")]
		[Address(RVA = "0x1D85874", Offset = "0x1D85874", VA = "0x7BBC585874")]
		public void StartMask([Optional] Action black_call_back, float dur = 1f)
		{
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068CA")]
		[Address(RVA = "0x1D85964", Offset = "0x1D85964", VA = "0x7BBC585964")]
		private void OnTweenEnd()
		{
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068CB")]
		[Address(RVA = "0x1D859E8", Offset = "0x1D859E8", VA = "0x7BBC5859E8")]
		public UIHudPortalMaskController()
		{
		}

		// Token: 0x04008575 RID: 34165
		[Token(Token = "0x4008575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIHudPortalMaskView m_View;

		// Token: 0x04008576 RID: 34166
		[Token(Token = "0x4008576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_IsToBlack;

		// Token: 0x04008577 RID: 34167
		[Token(Token = "0x4008577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action m_OnBackCallBack;
	}
}
