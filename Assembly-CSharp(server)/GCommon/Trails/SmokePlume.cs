using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x02001079 RID: 4217
	[Token(Token = "0x2001079")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EAB1C", Offset = "0x10EAB1C")]
	public class SmokePlume : TrailRenderer_Base
	{
		// Token: 0x0600407E RID: 16510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x249A6E8", Offset = "0x249A6E8", VA = "0x7BBCC9A6E8", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x249A85C", Offset = "0x249A85C", VA = "0x7BBCC9A85C", Slot = "12")]
		protected override void Reset()
		{
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004080")]
		[Address(RVA = "0x249AD40", Offset = "0x249AD40", VA = "0x7BBCC9AD40", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x249B1EC", Offset = "0x249B1EC", VA = "0x7BBCC9B1EC", Slot = "13")]
		protected override void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004082")]
		[Address(RVA = "0x249B3AC", Offset = "0x249B3AC", VA = "0x7BBCC9B3AC", Slot = "14")]
		protected override void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x6004083")]
		[Address(RVA = "0x249B51C", Offset = "0x249B51C", VA = "0x7BBCC9B51C", Slot = "10")]
		protected override Color GetMainColor()
		{
			return default(Color);
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x6004084")]
		[Address(RVA = "0x249B528", Offset = "0x249B528", VA = "0x7BBCC9B528", Slot = "11")]
		protected override int GetMaxNumberOfPoints()
		{
			return 0;
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004085")]
		[Address(RVA = "0x249B530", Offset = "0x249B530", VA = "0x7BBCC9B530")]
		public SmokePlume()
		{
		}

		// Token: 0x04005015 RID: 20501
		[Token(Token = "0x4005015")]
		[FieldOffset(Offset = "0x40")]
		public float TimeBetweenPoints;

		// Token: 0x04005016 RID: 20502
		[Token(Token = "0x4005016")]
		[FieldOffset(Offset = "0x44")]
		public Color MainColor;

		// Token: 0x04005017 RID: 20503
		[Token(Token = "0x4005017")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 ConstantForce;

		// Token: 0x04005018 RID: 20504
		[Token(Token = "0x4005018")]
		[FieldOffset(Offset = "0x60")]
		public float RandomForceScale;

		// Token: 0x04005019 RID: 20505
		[Token(Token = "0x4005019")]
		[FieldOffset(Offset = "0x64")]
		public int MaxNumberOfPoints;

		// Token: 0x0400501A RID: 20506
		[Token(Token = "0x400501A")]
		[FieldOffset(Offset = "0x68")]
		private float m_TimeSincePoint;
	}
}
