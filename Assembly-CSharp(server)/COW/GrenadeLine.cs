using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001263 RID: 4707
	[Token(Token = "0x2001263")]
	public class GrenadeLine : MonoBehaviour
	{
		// Token: 0x060048EF RID: 18671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x1765B90", Offset = "0x1765B90", VA = "0x7BBBF65B90")]
		private void Start()
		{
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x1765CCC", Offset = "0x1765CCC", VA = "0x7BBBF65CCC")]
		private void Destroy()
		{
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x1765D98", Offset = "0x1765D98", VA = "0x7BBBF65D98")]
		private void Update()
		{
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x17660B4", Offset = "0x17660B4", VA = "0x7BBBF660B4")]
		private void DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
		{
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x1766254", Offset = "0x1766254", VA = "0x7BBBF66254")]
		private void DrawLine2(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
		{
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x1766560", Offset = "0x1766560", VA = "0x7BBBF66560", Slot = "4")]
		protected virtual void OnGrenadeCrosshairFireChange(params object[] data)
		{
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x1766660", Offset = "0x1766660", VA = "0x7BBBF66660")]
		public GrenadeLine()
		{
		}

		// Token: 0x040071DA RID: 29146
		[Token(Token = "0x40071DA")]
		[FieldOffset(Offset = "0x18")]
		protected bool m_showGrenadeLine;

		// Token: 0x040071DB RID: 29147
		[Token(Token = "0x40071DB")]
		[FieldOffset(Offset = "0x20")]
		protected LineRenderer m_GrenadeLine;

		// Token: 0x040071DC RID: 29148
		[Token(Token = "0x40071DC")]
		[FieldOffset(Offset = "0x28")]
		private float interval;

		// Token: 0x040071DD RID: 29149
		[Token(Token = "0x40071DD")]
		private const int pos_count = 75;

		// Token: 0x040071DE RID: 29150
		[Token(Token = "0x40071DE")]
		private const float grenadeLauncher1stPosRatio = 0.15f;
	}
}
