using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F59 RID: 3929
	[Token(Token = "0x2000F59")]
	public class RotateAroundLocalAxis : MonoBehaviour
	{
		// Token: 0x060038EC RID: 14572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x2490018", Offset = "0x2490018", VA = "0x7BBCC90018")]
		private void Start()
		{
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x24900F8", Offset = "0x24900F8", VA = "0x7BBCC900F8")]
		private void Update()
		{
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x2490174", Offset = "0x2490174", VA = "0x7BBCC90174")]
		public RotateAroundLocalAxis()
		{
		}

		// Token: 0x04004ACA RID: 19146
		[Token(Token = "0x4004ACA")]
		[FieldOffset(Offset = "0x18")]
		public RotateAroundLocalAxis.ERotateAxis Axis;

		// Token: 0x04004ACB RID: 19147
		[Token(Token = "0x4004ACB")]
		[FieldOffset(Offset = "0x1C")]
		public float Speed;

		// Token: 0x04004ACC RID: 19148
		[Token(Token = "0x4004ACC")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 m_RotationAxis;

		// Token: 0x02000F5A RID: 3930
		[Token(Token = "0x2000F5A")]
		public enum ERotateAxis
		{
			// Token: 0x04004ACE RID: 19150
			[Token(Token = "0x4004ACE")]
			X,
			// Token: 0x04004ACF RID: 19151
			[Token(Token = "0x4004ACF")]
			Y,
			// Token: 0x04004AD0 RID: 19152
			[Token(Token = "0x4004AD0")]
			Z
		}
	}
}
