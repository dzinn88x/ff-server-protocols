using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025AA RID: 9642
	[Token(Token = "0x20025AA")]
	public class ShareCamera : MonoBehaviour
	{
		// Token: 0x0600C66A RID: 50794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66A")]
		[Address(RVA = "0x1B36E10", Offset = "0x1B36E10", VA = "0x7BBC336E10")]
		public void RenderScreenshot(RenderTexture rt, ShareCamera.AfterRender callback)
		{
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66B")]
		[Address(RVA = "0x1B36F18", Offset = "0x1B36F18", VA = "0x7BBC336F18")]
		private void OnPostRender()
		{
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66C")]
		[Address(RVA = "0x1B373A8", Offset = "0x1B373A8", VA = "0x7BBC3373A8")]
		public ShareCamera()
		{
		}

		// Token: 0x0400F8FC RID: 63740
		[Token(Token = "0x400F8FC")]
		[FieldOffset(Offset = "0x18")]
		private bool RenderFlag;

		// Token: 0x0400F8FD RID: 63741
		[Token(Token = "0x400F8FD")]
		[FieldOffset(Offset = "0x20")]
		private Camera ShareCam;

		// Token: 0x0400F8FE RID: 63742
		[Token(Token = "0x400F8FE")]
		[FieldOffset(Offset = "0x28")]
		private ShareCamera.AfterRender m_AfterRenderCallBack;

		// Token: 0x0400F8FF RID: 63743
		[Token(Token = "0x400F8FF")]
		[FieldOffset(Offset = "0x30")]
		private int delayCall;

		// Token: 0x020025AB RID: 9643
		// (Invoke) Token: 0x0600C66E RID: 50798
		[Token(Token = "0x20025AB")]
		public delegate void AfterRender();
	}
}
