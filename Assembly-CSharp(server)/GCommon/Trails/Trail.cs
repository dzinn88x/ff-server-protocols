using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x0200107C RID: 4220
	[Token(Token = "0x200107C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EAB8C", Offset = "0x10EAB8C")]
	public class Trail : TrailRenderer_Base
	{
		// Token: 0x06004090 RID: 16528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004090")]
		[Address(RVA = "0x249BC1C", Offset = "0x249BC1C", VA = "0x7BBCC9BC1C", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004091")]
		[Address(RVA = "0x249BCD4", Offset = "0x249BCD4", VA = "0x7BBCC9BCD4", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004092")]
		[Address(RVA = "0x249BE60", Offset = "0x249BE60", VA = "0x7BBCC9BE60", Slot = "12")]
		protected override void Reset()
		{
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004093")]
		[Address(RVA = "0x249BE8C", Offset = "0x249BE8C", VA = "0x7BBCC9BE8C", Slot = "9")]
		protected override void OnTranslate(Vector3 t)
		{
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x00013EF0 File Offset: 0x000120F0
		[Token(Token = "0x6004094")]
		[Address(RVA = "0x249BF40", Offset = "0x249BF40", VA = "0x7BBCC9BF40", Slot = "10")]
		protected override Color GetMainColor()
		{
			return default(Color);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00013F08 File Offset: 0x00012108
		[Token(Token = "0x6004095")]
		[Address(RVA = "0x249BF4C", Offset = "0x249BF4C", VA = "0x7BBCC9BF4C", Slot = "11")]
		protected override int GetMaxNumberOfPoints()
		{
			return 0;
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004096")]
		[Address(RVA = "0x249BF54", Offset = "0x249BF54", VA = "0x7BBCC9BF54")]
		public Trail()
		{
		}

		// Token: 0x04005022 RID: 20514
		[Token(Token = "0x4005022")]
		[FieldOffset(Offset = "0x40")]
		public Color MainColor;

		// Token: 0x04005023 RID: 20515
		[Token(Token = "0x4005023")]
		[FieldOffset(Offset = "0x50")]
		public float MinVertexDistance;

		// Token: 0x04005024 RID: 20516
		[Token(Token = "0x4005024")]
		[FieldOffset(Offset = "0x54")]
		public int MaxNumberOfPoints;

		// Token: 0x04005025 RID: 20517
		[Token(Token = "0x4005025")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_LastPosition;

		// Token: 0x04005026 RID: 20518
		[Token(Token = "0x4005026")]
		[FieldOffset(Offset = "0x64")]
		private float m_DistanceMoved;
	}
}
