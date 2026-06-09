using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019C6 RID: 6598
	[Token(Token = "0x20019C6")]
	internal class UIItemCameraController : MonoBehaviour
	{
		// Token: 0x0600879F RID: 34719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600879F")]
		[Address(RVA = "0x1E85110", Offset = "0x1E85110", VA = "0x7BBC685110")]
		private void Awake()
		{
		}

		// Token: 0x060087A0 RID: 34720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A0")]
		[Address(RVA = "0x1E85208", Offset = "0x1E85208", VA = "0x7BBC685208")]
		private void OnDestroy()
		{
		}

		// Token: 0x060087A1 RID: 34721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A1")]
		[Address(RVA = "0x1E852E4", Offset = "0x1E852E4", VA = "0x7BBC6852E4")]
		private void OnItemCameraStateChange(params object[] data)
		{
		}

		// Token: 0x060087A2 RID: 34722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087A2")]
		[Address(RVA = "0x1E853A4", Offset = "0x1E853A4", VA = "0x7BBC6853A4")]
		public UIItemCameraController()
		{
		}

		// Token: 0x04009623 RID: 38435
		[Token(Token = "0x4009623")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_Camera;
	}
}
