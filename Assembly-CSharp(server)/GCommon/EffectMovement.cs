using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000ED5 RID: 3797
	[Token(Token = "0x2000ED5")]
	public class EffectMovement : MonoBehaviour
	{
		// Token: 0x06003483 RID: 13443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003483")]
		[Address(RVA = "0x211128C", Offset = "0x211128C", VA = "0x7BBC91128C")]
		private void Start()
		{
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003484")]
		[Address(RVA = "0x21112E4", Offset = "0x21112E4", VA = "0x7BBC9112E4")]
		public void Init(Vector3 start_point, Vector3 end_point, Vector3 control_point, float time, bool need_auto_recycle)
		{
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x0000FB58 File Offset: 0x0000DD58
		[Token(Token = "0x6003485")]
		[Address(RVA = "0x21113A4", Offset = "0x21113A4", VA = "0x7BBC9113A4")]
		private Vector3 GetPosByBezierCurve(float rate)
		{
			return default(Vector3);
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x21114F8", Offset = "0x21114F8", VA = "0x7BBC9114F8")]
		private void Update()
		{
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x2111678", Offset = "0x2111678", VA = "0x7BBC911678")]
		public EffectMovement()
		{
		}

		// Token: 0x0400481C RID: 18460
		[Token(Token = "0x400481C")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 m_StartPoint;

		// Token: 0x0400481D RID: 18461
		[Token(Token = "0x400481D")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 m_ControlPoint;

		// Token: 0x0400481E RID: 18462
		[Token(Token = "0x400481E")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_EndPoint;

		// Token: 0x0400481F RID: 18463
		[Token(Token = "0x400481F")]
		[FieldOffset(Offset = "0x3C")]
		private float m_StartTime;

		// Token: 0x04004820 RID: 18464
		[Token(Token = "0x4004820")]
		[FieldOffset(Offset = "0x40")]
		private float m_DurationTime;

		// Token: 0x04004821 RID: 18465
		[Token(Token = "0x4004821")]
		[FieldOffset(Offset = "0x44")]
		private bool m_NeedAutoDestroy;

		// Token: 0x04004822 RID: 18466
		[Token(Token = "0x4004822")]
		[FieldOffset(Offset = "0x45")]
		private bool m_EndOfMove;

		// Token: 0x04004823 RID: 18467
		[Token(Token = "0x4004823")]
		[FieldOffset(Offset = "0x48")]
		private ReusableObject m_OwnedResuable;
	}
}
