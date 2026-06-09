using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200185D RID: 6237
	[Token(Token = "0x200185D")]
	public class UIGyroPositionController : MonoBehaviour
	{
		// Token: 0x06007AD5 RID: 31445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD5")]
		[Address(RVA = "0x16AE19C", Offset = "0x16AE19C", VA = "0x7BBBEAE19C")]
		public void SetRestoreTime(string text)
		{
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD6")]
		[Address(RVA = "0x16AE1C8", Offset = "0x16AE1C8", VA = "0x7BBBEAE1C8")]
		public void SetMoveSpeed(string text)
		{
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD7")]
		[Address(RVA = "0x16AE1F4", Offset = "0x16AE1F4", VA = "0x7BBBEAE1F4")]
		public void SetStayTime(string text)
		{
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD8")]
		[Address(RVA = "0x16AE220", Offset = "0x16AE220", VA = "0x7BBBEAE220")]
		private void Start()
		{
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AD9")]
		[Address(RVA = "0x16AE37C", Offset = "0x16AE37C", VA = "0x7BBBEAE37C")]
		private void Update()
		{
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007ADA")]
		[Address(RVA = "0x16AE6E0", Offset = "0x16AE6E0", VA = "0x7BBBEAE6E0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142578", Offset = "0x1142578")]
		private IEnumerator StayCoroutine()
		{
			return null;
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADB")]
		[Address(RVA = "0x16AE294", Offset = "0x16AE294", VA = "0x7BBBEAE294")]
		public void SetGyroSwitch(bool ison)
		{
		}

		// Token: 0x06007ADC RID: 31452 RVA: 0x00021CF0 File Offset: 0x0001FEF0
		[Token(Token = "0x6007ADC")]
		[Address(RVA = "0x16AE678", Offset = "0x16AE678", VA = "0x7BBBEAE678")]
		private Vector3 GetRotateOffset(Vector3 rotationRate, Vector3 userAcceleration, float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x06007ADD RID: 31453 RVA: 0x00021D08 File Offset: 0x0001FF08
		[Token(Token = "0x6007ADD")]
		[Address(RVA = "0x16AE780", Offset = "0x16AE780", VA = "0x7BBBEAE780")]
		private float GetRealAngle(float velocity, float acceleration, float deltaTime)
		{
			return 0f;
		}

		// Token: 0x06007ADE RID: 31454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007ADE")]
		[Address(RVA = "0x16AE7A0", Offset = "0x16AE7A0", VA = "0x7BBBEAE7A0")]
		public UIGyroPositionController()
		{
		}

		// Token: 0x04008F67 RID: 36711
		[Token(Token = "0x4008F67")]
		[FieldOffset(Offset = "0x18")]
		public float restoreSpeed;

		// Token: 0x04008F68 RID: 36712
		[Token(Token = "0x4008F68")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		// Token: 0x04008F69 RID: 36713
		[Token(Token = "0x4008F69")]
		[FieldOffset(Offset = "0x20")]
		public float stayTime;

		// Token: 0x04008F6A RID: 36714
		[Token(Token = "0x4008F6A")]
		[FieldOffset(Offset = "0x24")]
		private float nextStayTime;

		// Token: 0x04008F6B RID: 36715
		[Token(Token = "0x4008F6B")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 startPosition;

		// Token: 0x04008F6C RID: 36716
		[Token(Token = "0x4008F6C")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 positionOffset;

		// Token: 0x04008F6D RID: 36717
		[Token(Token = "0x4008F6D")]
		[FieldOffset(Offset = "0x40")]
		private bool isRestoring;

		// Token: 0x04008F6E RID: 36718
		[Token(Token = "0x4008F6E")]
		[FieldOffset(Offset = "0x41")]
		private bool isStaying;

		// Token: 0x0200185E RID: 6238
		[Token(Token = "0x200185E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3E6C", Offset = "0x10F3E6C")]
		private sealed class <StayCoroutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007ADF RID: 31455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ADF")]
			[Address(RVA = "0x16AE754", Offset = "0x16AE754", VA = "0x7BBBEAE754")]
			[DebuggerHidden]
			public <StayCoroutine>d__13(int <>1__state)
			{
			}

			// Token: 0x06007AE0 RID: 31456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AE0")]
			[Address(RVA = "0x16AE7C4", Offset = "0x16AE7C4", VA = "0x7BBBEAE7C4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007AE1 RID: 31457 RVA: 0x00021D20 File Offset: 0x0001FF20
			[Token(Token = "0x6007AE1")]
			[Address(RVA = "0x16AE7C8", Offset = "0x16AE7C8", VA = "0x7BBBEAE7C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097C")]
			private object Current
			{
				[Token(Token = "0x6007AE2")]
				[Address(RVA = "0x16AE894", Offset = "0x16AE894", VA = "0x7BBBEAE894", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007AE3 RID: 31459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AE3")]
			[Address(RVA = "0x16AE89C", Offset = "0x16AE89C", VA = "0x7BBBEAE89C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097D")]
			private object Current
			{
				[Token(Token = "0x6007AE4")]
				[Address(RVA = "0x16AE904", Offset = "0x16AE904", VA = "0x7BBBEAE904", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008F6F RID: 36719
			[Token(Token = "0x4008F6F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008F70 RID: 36720
			[Token(Token = "0x4008F70")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008F71 RID: 36721
			[Token(Token = "0x4008F71")]
			[FieldOffset(Offset = "0x20")]
			public UIGyroPositionController <>4__this;
		}
	}
}
