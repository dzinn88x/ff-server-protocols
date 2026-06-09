using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x0200107A RID: 4218
	[Token(Token = "0x200107A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EAB54", Offset = "0x10EAB54")]
	public class SmokeTrail : TrailRenderer_Base
	{
		// Token: 0x06004086 RID: 16518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004086")]
		[Address(RVA = "0x249B5E8", Offset = "0x249B5E8", VA = "0x7BBCC9B5E8", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004087")]
		[Address(RVA = "0x249B6A0", Offset = "0x249B6A0", VA = "0x7BBCC9B6A0", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x249B82C", Offset = "0x249B82C", VA = "0x7BBCC9B82C", Slot = "12")]
		protected override void Reset()
		{
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004089")]
		[Address(RVA = "0x249B860", Offset = "0x249B860", VA = "0x7BBCC9B860", Slot = "13")]
		protected override void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408A")]
		[Address(RVA = "0x249BA20", Offset = "0x249BA20", VA = "0x7BBCC9BA20", Slot = "9")]
		protected override void OnTranslate(Vector3 t)
		{
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x600408B")]
		[Address(RVA = "0x249BAD4", Offset = "0x249BAD4", VA = "0x7BBCC9BAD4", Slot = "10")]
		protected override Color GetMainColor()
		{
			return default(Color);
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x00013ED8 File Offset: 0x000120D8
		[Token(Token = "0x600408C")]
		[Address(RVA = "0x249BAE0", Offset = "0x249BAE0", VA = "0x7BBCC9BAE0", Slot = "11")]
		protected override int GetMaxNumberOfPoints()
		{
			return 0;
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408D")]
		[Address(RVA = "0x249BAE8", Offset = "0x249BAE8", VA = "0x7BBCC9BAE8")]
		public SmokeTrail()
		{
		}

		// Token: 0x0400501B RID: 20507
		[Token(Token = "0x400501B")]
		[FieldOffset(Offset = "0x40")]
		public Color MainColor;

		// Token: 0x0400501C RID: 20508
		[Token(Token = "0x400501C")]
		[FieldOffset(Offset = "0x50")]
		public float MinVertexDistance;

		// Token: 0x0400501D RID: 20509
		[Token(Token = "0x400501D")]
		[FieldOffset(Offset = "0x54")]
		public int MaxNumberOfPoints;

		// Token: 0x0400501E RID: 20510
		[Token(Token = "0x400501E")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_LastPosition;

		// Token: 0x0400501F RID: 20511
		[Token(Token = "0x400501F")]
		[FieldOffset(Offset = "0x64")]
		private float m_DistanceMoved;

		// Token: 0x04005020 RID: 20512
		[Token(Token = "0x4005020")]
		[FieldOffset(Offset = "0x68")]
		public float RandomForceScale;
	}
}
