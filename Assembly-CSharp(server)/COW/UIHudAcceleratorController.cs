using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001864 RID: 6244
	[Token(Token = "0x2001864")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3F24", Offset = "0x10F3F24")]
	internal class UIHudAcceleratorController : UIHudVehicleButtonBaseController
	{
		// Token: 0x06007B12 RID: 31506 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		[Token(Token = "0x6007B12")]
		[Address(RVA = "0x1D65A08", Offset = "0x1D65A08", VA = "0x7BBC565A08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B13")]
		[Address(RVA = "0x1D65A58", Offset = "0x1D65A58", VA = "0x7BBC565A58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B14")]
		[Address(RVA = "0x1D65AD4", Offset = "0x1D65AD4", VA = "0x7BBC565AD4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B15")]
		[Address(RVA = "0x1D65ADC", Offset = "0x1D65ADC", VA = "0x7BBC565ADC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B16")]
		[Address(RVA = "0x1D65B38", Offset = "0x1D65B38", VA = "0x7BBC565B38")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114263C", Offset = "0x114263C")]
		private IEnumerator CheckInputTouch()
		{
			return null;
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B17")]
		[Address(RVA = "0x1D65BD8", Offset = "0x1D65BD8", VA = "0x7BBC565BD8", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		[Token(Token = "0x6007B18")]
		[Address(RVA = "0x1D65C20", Offset = "0x1D65C20", VA = "0x7BBC565C20", Slot = "34")]
		protected override EControlMode ShowInControlMode()
		{
			return EControlMode.Default;
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B19")]
		[Address(RVA = "0x1D65C28", Offset = "0x1D65C28", VA = "0x7BBC565C28")]
		public UIHudAcceleratorController()
		{
		}

		// Token: 0x04008F94 RID: 36756
		[Token(Token = "0x4008F94")]
		[FieldOffset(Offset = "0x60")]
		private UIHudAcceleratorView m_View;

		// Token: 0x02001865 RID: 6245
		[Token(Token = "0x2001865")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3F5C", Offset = "0x10F3F5C")]
		private sealed class <CheckInputTouch>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007B1A RID: 31514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B1A")]
			[Address(RVA = "0x1D65BAC", Offset = "0x1D65BAC", VA = "0x7BBC565BAC")]
			[DebuggerHidden]
			public <CheckInputTouch>d__5(int <>1__state)
			{
			}

			// Token: 0x06007B1B RID: 31515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B1B")]
			[Address(RVA = "0x1D65C30", Offset = "0x1D65C30", VA = "0x7BBC565C30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007B1C RID: 31516 RVA: 0x00021DF8 File Offset: 0x0001FFF8
			[Token(Token = "0x6007B1C")]
			[Address(RVA = "0x1D65C34", Offset = "0x1D65C34", VA = "0x7BBC565C34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x06007B1D RID: 31517 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097E")]
			private object Current
			{
				[Token(Token = "0x6007B1D")]
				[Address(RVA = "0x1D65F7C", Offset = "0x1D65F7C", VA = "0x7BBC565F7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007B1E RID: 31518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B1E")]
			[Address(RVA = "0x1D65F84", Offset = "0x1D65F84", VA = "0x7BBC565F84", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06007B1F RID: 31519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700097F")]
			private object Current
			{
				[Token(Token = "0x6007B1F")]
				[Address(RVA = "0x1D65FEC", Offset = "0x1D65FEC", VA = "0x7BBC565FEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008F95 RID: 36757
			[Token(Token = "0x4008F95")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008F96 RID: 36758
			[Token(Token = "0x4008F96")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008F97 RID: 36759
			[Token(Token = "0x4008F97")]
			[FieldOffset(Offset = "0x20")]
			public UIHudAcceleratorController <>4__this;
		}
	}
}
