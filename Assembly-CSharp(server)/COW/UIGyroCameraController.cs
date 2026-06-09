using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200185B RID: 6235
	[Token(Token = "0x200185B")]
	public class UIGyroCameraController : MonoBehaviour
	{
		// Token: 0x06007AC8 RID: 31432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC8")]
		[Address(RVA = "0x16AD9C8", Offset = "0x16AD9C8", VA = "0x7BBBEAD9C8")]
		private void Start()
		{
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AC9")]
		[Address(RVA = "0x16ADA54", Offset = "0x16ADA54", VA = "0x7BBBEADA54")]
		private void Update()
		{
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007ACA")]
		[Address(RVA = "0x16ADE14", Offset = "0x16ADE14", VA = "0x7BBBEADE14")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11424C4", Offset = "0x11424C4")]
		private IEnumerator StayCoroutine()
		{
			return null;
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACB")]
		[Address(RVA = "0x16ADEB4", Offset = "0x16ADEB4", VA = "0x7BBBEADEB4")]
		public void SetGyroSwitch(bool ison)
		{
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		[Token(Token = "0x6007ACC")]
		[Address(RVA = "0x16ADDAC", Offset = "0x16ADDAC", VA = "0x7BBBEADDAC")]
		private Vector3 GetRotateOffset(Vector3 rotationRate, Vector3 userAcceleration, float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		[Token(Token = "0x6007ACD")]
		[Address(RVA = "0x16AE010", Offset = "0x16AE010", VA = "0x7BBBEAE010")]
		private float GetRealAngle(float velocity, float acceleration, float deltaTime)
		{
			return 0f;
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ACE")]
		[Address(RVA = "0x16AE030", Offset = "0x16AE030", VA = "0x7BBBEAE030")]
		public UIGyroCameraController()
		{
		}

		// Token: 0x04008F5C RID: 36700
		[Token(Token = "0x4008F5C")]
		[FieldOffset(Offset = "0x18")]
		public float restoreSpeed;

		// Token: 0x04008F5D RID: 36701
		[Token(Token = "0x4008F5D")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		// Token: 0x04008F5E RID: 36702
		[Token(Token = "0x4008F5E")]
		[FieldOffset(Offset = "0x20")]
		public float stayTime;

		// Token: 0x04008F5F RID: 36703
		[Token(Token = "0x4008F5F")]
		[FieldOffset(Offset = "0x24")]
		private float nextStayTime;

		// Token: 0x04008F60 RID: 36704
		[Token(Token = "0x4008F60")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 startRotation;

		// Token: 0x04008F61 RID: 36705
		[Token(Token = "0x4008F61")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 rotateOffset;

		// Token: 0x04008F62 RID: 36706
		[Token(Token = "0x4008F62")]
		[FieldOffset(Offset = "0x40")]
		private bool isRestoring;

		// Token: 0x04008F63 RID: 36707
		[Token(Token = "0x4008F63")]
		[FieldOffset(Offset = "0x41")]
		private bool isStaying;

		// Token: 0x0200185C RID: 6236
		[Token(Token = "0x200185C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3E5C", Offset = "0x10F3E5C")]
		private sealed class <StayCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007ACF RID: 31439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ACF")]
			[Address(RVA = "0x16ADE88", Offset = "0x16ADE88", VA = "0x7BBBEADE88")]
			[DebuggerHidden]
			public <StayCoroutine>d__10(int <>1__state)
			{
			}

			// Token: 0x06007AD0 RID: 31440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD0")]
			[Address(RVA = "0x16AE054", Offset = "0x16AE054", VA = "0x7BBBEAE054", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007AD1 RID: 31441 RVA: 0x00021CD8 File Offset: 0x0001FED8
			[Token(Token = "0x6007AD1")]
			[Address(RVA = "0x16AE058", Offset = "0x16AE058", VA = "0x7BBBEAE058", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x06007AD2 RID: 31442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097A")]
			private object Current
			{
				[Token(Token = "0x6007AD2")]
				[Address(RVA = "0x16AE124", Offset = "0x16AE124", VA = "0x7BBBEAE124", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007AD3 RID: 31443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AD3")]
			[Address(RVA = "0x16AE12C", Offset = "0x16AE12C", VA = "0x7BBBEAE12C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x06007AD4 RID: 31444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097B")]
			private object Current
			{
				[Token(Token = "0x6007AD4")]
				[Address(RVA = "0x16AE194", Offset = "0x16AE194", VA = "0x7BBBEAE194", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008F64 RID: 36708
			[Token(Token = "0x4008F64")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008F65 RID: 36709
			[Token(Token = "0x4008F65")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008F66 RID: 36710
			[Token(Token = "0x4008F66")]
			[FieldOffset(Offset = "0x20")]
			public UIGyroCameraController <>4__this;
		}
	}
}
