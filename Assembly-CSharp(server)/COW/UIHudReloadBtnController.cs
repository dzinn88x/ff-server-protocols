using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200194A RID: 6474
	[Token(Token = "0x200194A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5EFC", Offset = "0x10F5EFC")]
	internal class UIHudReloadBtnController : UIHudButtonBaseController
	{
		// Token: 0x0600834B RID: 33611 RVA: 0x00023AD8 File Offset: 0x00021CD8
		[Token(Token = "0x600834B")]
		[Address(RVA = "0x17F140C", Offset = "0x17F140C", VA = "0x7BBBFF140C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600834C")]
		[Address(RVA = "0x17F145C", Offset = "0x17F145C", VA = "0x7BBBFF145C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600834D")]
		[Address(RVA = "0x17F16AC", Offset = "0x17F16AC", VA = "0x7BBBFF16AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600834E")]
		[Address(RVA = "0x17F18C8", Offset = "0x17F18C8", VA = "0x7BBBFF18C8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600834F")]
		[Address(RVA = "0x17F1AD0", Offset = "0x17F1AD0", VA = "0x7BBBFF1AD0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008350 RID: 33616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008350")]
		[Address(RVA = "0x17F1B18", Offset = "0x17F1B18", VA = "0x7BBBFF1B18", Slot = "28")]
		protected override void OnBtnDown()
		{
		}

		// Token: 0x06008351 RID: 33617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008351")]
		[Address(RVA = "0x17F1B2C", Offset = "0x17F1B2C", VA = "0x7BBBFF1B2C", Slot = "29")]
		protected override void OnBtnUp()
		{
		}

		// Token: 0x06008352 RID: 33618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008352")]
		[Address(RVA = "0x17F1B40", Offset = "0x17F1B40", VA = "0x7BBBFF1B40", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008353 RID: 33619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008353")]
		[Address(RVA = "0x17F1DD8", Offset = "0x17F1DD8", VA = "0x7BBBFF1DD8")]
		private void OnHudSettingChange(params object[] param)
		{
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008354")]
		[Address(RVA = "0x17F1DFC", Offset = "0x17F1DFC", VA = "0x7BBBFF1DFC")]
		private void OnWeaponReload(object[] data)
		{
		}

		// Token: 0x06008355 RID: 33621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008355")]
		[Address(RVA = "0x17F1EC4", Offset = "0x17F1EC4", VA = "0x7BBBFF1EC4")]
		private void OnWeaponReloadEnd(object[] data)
		{
		}

		// Token: 0x06008356 RID: 33622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008356")]
		[Address(RVA = "0x17F1F04", Offset = "0x17F1F04", VA = "0x7BBBFF1F04")]
		private void OnWeaponChanged(object[] data)
		{
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008357")]
		[Address(RVA = "0x17F1F30", Offset = "0x17F1F30", VA = "0x7BBBFF1F30")]
		private void OnItemChange(object[] data)
		{
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008358")]
		[Address(RVA = "0x17F18F8", Offset = "0x17F18F8", VA = "0x7BBBFF18F8")]
		private void UpdateShowTiming()
		{
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008359")]
		[Address(RVA = "0x17F1964", Offset = "0x17F1964", VA = "0x7BBBFF1964")]
		private void UpdateShowHide()
		{
		}

		// Token: 0x0600835A RID: 33626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600835A")]
		[Address(RVA = "0x17F1B8C", Offset = "0x17F1B8C", VA = "0x7BBBFF1B8C")]
		private void UpdateCd(bool reloading, float cd)
		{
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600835B")]
		[Address(RVA = "0x17F2054", Offset = "0x17F2054", VA = "0x7BBBFF2054")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11432B0", Offset = "0x11432B0")]
		private IEnumerator StartCooldown(float f)
		{
			return null;
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600835C")]
		[Address(RVA = "0x17F2118", Offset = "0x17F2118", VA = "0x7BBBFF2118")]
		public UIHudReloadBtnController()
		{
		}

		// Token: 0x04009431 RID: 37937
		[Token(Token = "0x4009431")]
		[FieldOffset(Offset = "0x60")]
		private UIHudReloadBtnView m_View;

		// Token: 0x04009432 RID: 37938
		[Token(Token = "0x4009432")]
		[FieldOffset(Offset = "0x68")]
		private EReloadSetting m_ShowTiming;

		// Token: 0x04009433 RID: 37939
		[Token(Token = "0x4009433")]
		[FieldOffset(Offset = "0x70")]
		private IEnumerator m_CurrentCoroutine;

		// Token: 0x0200194B RID: 6475
		[Token(Token = "0x200194B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F5F34", Offset = "0x10F5F34")]
		private sealed class <StartCooldown>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600835D RID: 33629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600835D")]
			[Address(RVA = "0x17F20EC", Offset = "0x17F20EC", VA = "0x7BBBFF20EC")]
			[DebuggerHidden]
			public <StartCooldown>d__19(int <>1__state)
			{
			}

			// Token: 0x0600835E RID: 33630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600835E")]
			[Address(RVA = "0x17F2120", Offset = "0x17F2120", VA = "0x7BBBFF2120", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600835F RID: 33631 RVA: 0x00023AF0 File Offset: 0x00021CF0
			[Token(Token = "0x600835F")]
			[Address(RVA = "0x17F2124", Offset = "0x17F2124", VA = "0x7BBBFF2124", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x06008360 RID: 33632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009AD")]
			private object Current
			{
				[Token(Token = "0x6008360")]
				[Address(RVA = "0x17F2230", Offset = "0x17F2230", VA = "0x7BBBFF2230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008361 RID: 33633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008361")]
			[Address(RVA = "0x17F2238", Offset = "0x17F2238", VA = "0x7BBBFF2238", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x06008362 RID: 33634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009AE")]
			private object Current
			{
				[Token(Token = "0x6008362")]
				[Address(RVA = "0x17F22A0", Offset = "0x17F22A0", VA = "0x7BBBFF22A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009434 RID: 37940
			[Token(Token = "0x4009434")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009435 RID: 37941
			[Token(Token = "0x4009435")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009436 RID: 37942
			[Token(Token = "0x4009436")]
			[FieldOffset(Offset = "0x20")]
			public float f;

			// Token: 0x04009437 RID: 37943
			[Token(Token = "0x4009437")]
			[FieldOffset(Offset = "0x28")]
			public UIHudReloadBtnController <>4__this;

			// Token: 0x04009438 RID: 37944
			[Token(Token = "0x4009438")]
			[FieldOffset(Offset = "0x30")]
			private float <t>5__2;
		}
	}
}
