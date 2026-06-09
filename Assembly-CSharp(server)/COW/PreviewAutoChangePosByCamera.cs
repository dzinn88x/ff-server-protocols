using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200127F RID: 4735
	[Token(Token = "0x200127F")]
	public class PreviewAutoChangePosByCamera : MonoBehaviour
	{
		// Token: 0x06004964 RID: 18788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x17447A8", Offset = "0x17447A8", VA = "0x7BBBF447A8")]
		public void SetCamera(Camera cam)
		{
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x1744A9C", Offset = "0x1744A9C", VA = "0x7BBBF44A9C")]
		public PreviewAutoChangePosByCamera()
		{
		}

		// Token: 0x04007241 RID: 29249
		[Token(Token = "0x4007241")]
		[FieldOffset(Offset = "0x18")]
		public float radio;

		// Token: 0x04007242 RID: 29250
		[Token(Token = "0x4007242")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_camera;
	}
}
