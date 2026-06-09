using System;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW
{
	// Token: 0x020025DC RID: 9692
	[Token(Token = "0x20025DC")]
	public class TaskMirror : BaseTask
	{
		// Token: 0x0600C751 RID: 51025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C751")]
		[Address(RVA = "0x1B44B10", Offset = "0x1B44B10", VA = "0x7BBC344B10")]
		private void Awake()
		{
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C752")]
		[Address(RVA = "0x1B44FB0", Offset = "0x1B44FB0", VA = "0x7BBC344FB0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C753")]
		[Address(RVA = "0x1B4518C", Offset = "0x1B4518C", VA = "0x7BBC34518C")]
		private void OnDisable()
		{
		}

		// Token: 0x0600C754 RID: 51028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C754")]
		[Address(RVA = "0x1B453B8", Offset = "0x1B453B8", VA = "0x7BBC3453B8")]
		private void FingerSet(LeanFinger finger)
		{
		}

		// Token: 0x0600C755 RID: 51029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C755")]
		[Address(RVA = "0x1B456F8", Offset = "0x1B456F8", VA = "0x7BBC3456F8")]
		private void FingerDown(LeanFinger finger)
		{
		}

		// Token: 0x0600C756 RID: 51030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C756")]
		[Address(RVA = "0x1B45420", Offset = "0x1B45420", VA = "0x7BBC345420")]
		private void MaskDrawLine(Vector2 pos1, Vector2 pos2, float radius)
		{
		}

		// Token: 0x0600C757 RID: 51031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C757")]
		[Address(RVA = "0x1B45818", Offset = "0x1B45818", VA = "0x7BBC345818")]
		private void MaskDrawCircle(Vector2 localPos, float radius)
		{
		}

		// Token: 0x0600C758 RID: 51032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C758")]
		[Address(RVA = "0x1B45A68", Offset = "0x1B45A68", VA = "0x7BBC345A68")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600C759 RID: 51033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C759")]
		[Address(RVA = "0x1B45C64", Offset = "0x1B45C64", VA = "0x7BBC345C64")]
		private void CheckComplete()
		{
		}

		// Token: 0x0600C75A RID: 51034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C75A")]
		[Address(RVA = "0x1B45CE0", Offset = "0x1B45CE0", VA = "0x7BBC345CE0")]
		public TaskMirror()
		{
		}

		// Token: 0x0400F9A3 RID: 63907
		[Token(Token = "0x400F9A3")]
		[FieldOffset(Offset = "0x68")]
		public Camera camera;

		// Token: 0x0400F9A4 RID: 63908
		[Token(Token = "0x400F9A4")]
		[FieldOffset(Offset = "0x70")]
		public UITexture texture;

		// Token: 0x0400F9A5 RID: 63909
		[Token(Token = "0x400F9A5")]
		[FieldOffset(Offset = "0x78")]
		public float radius;

		// Token: 0x0400F9A6 RID: 63910
		[Token(Token = "0x400F9A6")]
		[FieldOffset(Offset = "0x7C")]
		public float successRate;

		// Token: 0x0400F9A7 RID: 63911
		[Token(Token = "0x400F9A7")]
		[FieldOffset(Offset = "0x80")]
		private Color32[] m_TarColor;

		// Token: 0x0400F9A8 RID: 63912
		[Token(Token = "0x400F9A8")]
		[FieldOffset(Offset = "0x88")]
		private bool[] m_BMask;

		// Token: 0x0400F9A9 RID: 63913
		[Token(Token = "0x400F9A9")]
		[FieldOffset(Offset = "0x90")]
		private bool m_IsDirty;

		// Token: 0x0400F9AA RID: 63914
		[Token(Token = "0x400F9AA")]
		[FieldOffset(Offset = "0x94")]
		private float m_Radius2;

		// Token: 0x0400F9AB RID: 63915
		[Token(Token = "0x400F9AB")]
		[FieldOffset(Offset = "0x98")]
		private int m_Count;

		// Token: 0x0400F9AC RID: 63916
		[Token(Token = "0x400F9AC")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_IsComplete;

		// Token: 0x0400F9AD RID: 63917
		[Token(Token = "0x400F9AD")]
		[FieldOffset(Offset = "0xA0")]
		private Texture2D m_mask;
	}
}
