using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x0200107D RID: 4221
	[Token(Token = "0x200107D")]
	public abstract class TrailRenderer_Base : MonoBehaviour
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004097")]
		[Address(RVA = "0x249BF98", Offset = "0x249BF98", VA = "0x7BBCC9BF98", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004098")]
		[Address(RVA = "0x249A780", Offset = "0x249A780", VA = "0x7BBCC9A780", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004099")]
		[Address(RVA = "0x249C03C", Offset = "0x249C03C", VA = "0x7BBCC9C03C", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409A")]
		[Address(RVA = "0x249B17C", Offset = "0x249B17C", VA = "0x7BBCC9B17C", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409B")]
		[Address(RVA = "0x249CFD8", Offset = "0x249CFD8", VA = "0x7BBCC9CFD8", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409C")]
		[Address(RVA = "0x249D004", Offset = "0x249D004", VA = "0x7BBCC9D004", Slot = "9")]
		protected virtual void OnTranslate(Vector3 t)
		{
		}

		// Token: 0x0600409D RID: 16541
		[Token(Token = "0x600409D")]
		protected abstract Color GetMainColor();

		// Token: 0x0600409E RID: 16542
		[Token(Token = "0x600409E")]
		protected abstract int GetMaxNumberOfPoints();

		// Token: 0x0600409F RID: 16543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x249AAA0", Offset = "0x249AAA0", VA = "0x7BBCC9AAA0", Slot = "12")]
		protected virtual void Reset()
		{
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A0")]
		[Address(RVA = "0x249D008", Offset = "0x249D008", VA = "0x7BBCC9D008", Slot = "13")]
		protected virtual void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A1")]
		[Address(RVA = "0x249D00C", Offset = "0x249D00C", VA = "0x7BBCC9D00C", Slot = "14")]
		protected virtual void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x249ADBC", Offset = "0x249ADBC", VA = "0x7BBCC9ADBC")]
		protected void AddPoint(Vector3 pos)
		{
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x249C144", Offset = "0x249C144", VA = "0x7BBCC9C144")]
		private void GenerateMesh(PCTrail trail)
		{
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A4")]
		[Address(RVA = "0x249C040", Offset = "0x249C040", VA = "0x7BBCC9C040")]
		private void UpdatePoints(PCTrail line, float deltaTime)
		{
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A5")]
		[Address(RVA = "0x249D118", Offset = "0x249D118", VA = "0x7BBCC9D118", Slot = "15")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113C3B0", Offset = "0x113C3B0")]
		protected virtual void UpdatePoint(PCTrailPoint pCTrailPoint, float deltaTime)
		{
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x00013F20 File Offset: 0x00012120
		[Token(Token = "0x60040A6")]
		[Address(RVA = "0x249D010", Offset = "0x249D010", VA = "0x7BBCC9D010")]
		private int NumberOfActivePoints(PCTrail line)
		{
			return 0;
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x249D11C", Offset = "0x249D11C", VA = "0x7BBCC9D11C")]
		[Attribute(Name = "ContextMenu", RVA = "0x113C3EC", Offset = "0x113C3EC")]
		protected void ToggleSizeInputStyle()
		{
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x249D164", Offset = "0x249D164", VA = "0x7BBCC9D164")]
		[Attribute(Name = "ContextMenu", RVA = "0x113C424", Offset = "0x113C424")]
		protected void ToggleColorInputStyle()
		{
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x249D1AC", Offset = "0x249D1AC", VA = "0x7BBCC9D1AC")]
		public void LifeDecayEnabled(bool enabled)
		{
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x249D1BC", Offset = "0x249D1BC", VA = "0x7BBCC9D1BC")]
		public void Translate(Vector3 t)
		{
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x249D32C", Offset = "0x249D32C", VA = "0x7BBCC9D32C")]
		public void ClearSystem(bool emitState)
		{
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x249D358", Offset = "0x249D358", VA = "0x7BBCC9D358", Slot = "16")]
		protected virtual void InitPCTrail(Type type)
		{
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x249D3E0", Offset = "0x249D3E0", VA = "0x7BBCC9D3E0")]
		private void OnEnable()
		{
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x249D3F4", Offset = "0x249D3F4", VA = "0x7BBCC9D3F4")]
		private void OnDisable()
		{
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x249B5E0", Offset = "0x249B5E0", VA = "0x7BBCC9B5E0")]
		protected TrailRenderer_Base()
		{
		}

		// Token: 0x04005027 RID: 20519
		[Token(Token = "0x4005027")]
		[FieldOffset(Offset = "0x18")]
		public PCTrailRendererData TrailData;

		// Token: 0x04005028 RID: 20520
		[Token(Token = "0x4005028")]
		[FieldOffset(Offset = "0x20")]
		protected bool m_NoDecay;

		// Token: 0x04005029 RID: 20521
		[Token(Token = "0x4005029")]
		[FieldOffset(Offset = "0x28")]
		private PCTrail m_ActiveTrail;

		// Token: 0x0400502A RID: 20522
		[Token(Token = "0x400502A")]
		[FieldOffset(Offset = "0x30")]
		protected Transform m_Transform;

		// Token: 0x0400502B RID: 20523
		[Token(Token = "0x400502B")]
		[FieldOffset(Offset = "0x38")]
		private TrailManager m_Manager;
	}
}
