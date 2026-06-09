using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x0200107F RID: 4223
	[Token(Token = "0x200107F")]
	public class PCTrailPoint
	{
		// Token: 0x060040B2 RID: 16562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x249A640", Offset = "0x249A640", VA = "0x7BBCC9A640", Slot = "4")]
		public virtual void Update(float deltaTime)
		{
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00013F38 File Offset: 0x00012138
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x249A650", Offset = "0x249A650", VA = "0x7BBCC9A650")]
		public float TimeActive()
		{
			return 0f;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x249A658", Offset = "0x249A658", VA = "0x7BBCC9A658")]
		public void SetTimeActive(float time)
		{
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x249A660", Offset = "0x249A660", VA = "0x7BBCC9A660")]
		public void SetDistanceFromStart(float distance)
		{
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x249A668", Offset = "0x249A668", VA = "0x7BBCC9A668")]
		public float GetDistanceFromStart()
		{
			return 0f;
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x249A670", Offset = "0x249A670", VA = "0x7BBCC9A670")]
		public PCTrailPoint()
		{
		}

		// Token: 0x04005035 RID: 20533
		[Token(Token = "0x4005035")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Forward;

		// Token: 0x04005036 RID: 20534
		[Token(Token = "0x4005036")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Position;

		// Token: 0x04005037 RID: 20535
		[Token(Token = "0x4005037")]
		[FieldOffset(Offset = "0x28")]
		public int PointNumber;

		// Token: 0x04005038 RID: 20536
		[Token(Token = "0x4005038")]
		[FieldOffset(Offset = "0x2C")]
		private float m_TimeActive;

		// Token: 0x04005039 RID: 20537
		[Token(Token = "0x4005039")]
		[FieldOffset(Offset = "0x30")]
		private float m_Distance;
	}
}
