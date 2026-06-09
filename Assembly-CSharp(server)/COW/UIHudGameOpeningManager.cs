using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018C5 RID: 6341
	[Token(Token = "0x20018C5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4CB4", Offset = "0x10F4CB4")]
	internal class UIHudGameOpeningManager : UIBaseController
	{
		// Token: 0x06007E42 RID: 32322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E42")]
		[Address(RVA = "0x1C112E8", Offset = "0x1C112E8", VA = "0x7BBC4112E8", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E43")]
		[Address(RVA = "0x1C117F0", Offset = "0x1C117F0", VA = "0x7BBC4117F0")]
		private void Start()
		{
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E44")]
		[Address(RVA = "0x1C12250", Offset = "0x1C12250", VA = "0x7BBC412250", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E45")]
		[Address(RVA = "0x1C11940", Offset = "0x1C11940", VA = "0x7BBC411940")]
		private void SetUIData()
		{
		}

		// Token: 0x06007E46 RID: 32326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E46")]
		[Address(RVA = "0x1C12398", Offset = "0x1C12398", VA = "0x7BBC412398")]
		private void EnableTypeWriter()
		{
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007E47")]
		[Address(RVA = "0x1C124D8", Offset = "0x1C124D8", VA = "0x7BBC4124D8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142C28", Offset = "0x1142C28")]
		private IEnumerator ShowAnimSprite()
		{
			return null;
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E48")]
		[Address(RVA = "0x1C12578", Offset = "0x1C12578", VA = "0x7BBC412578")]
		private void ShowTween(params object[] data)
		{
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E49")]
		[Address(RVA = "0x1C12994", Offset = "0x1C12994", VA = "0x7BBC412994")]
		public void OnTypeWriterEffectFinished()
		{
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4A")]
		[Address(RVA = "0x1C12ABC", Offset = "0x1C12ABC", VA = "0x7BBC412ABC")]
		private void resizeParticleShapeSize(GameObject effectGo)
		{
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4B")]
		[Address(RVA = "0x1C12C54", Offset = "0x1C12C54", VA = "0x7BBC412C54")]
		private void OnTweenFinish()
		{
		}

		// Token: 0x06007E4C RID: 32332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4C")]
		[Address(RVA = "0x1C12C58", Offset = "0x1C12C58", VA = "0x7BBC412C58")]
		private void OnOpeningEnd(object[] data)
		{
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E4D")]
		[Address(RVA = "0x1C12CD4", Offset = "0x1C12CD4", VA = "0x7BBC412CD4")]
		public UIHudGameOpeningManager()
		{
		}

		// Token: 0x0400919F RID: 37279
		[Token(Token = "0x400919F")]
		[FieldOffset(Offset = "0x58")]
		public UISprite topBg;

		// Token: 0x040091A0 RID: 37280
		[Token(Token = "0x40091A0")]
		[FieldOffset(Offset = "0x60")]
		public UISprite bottomBg;

		// Token: 0x040091A1 RID: 37281
		[Token(Token = "0x40091A1")]
		[FieldOffset(Offset = "0x68")]
		public UILabel mapTxt;

		// Token: 0x040091A2 RID: 37282
		[Token(Token = "0x40091A2")]
		[FieldOffset(Offset = "0x70")]
		public UILabel dateTxt;

		// Token: 0x040091A3 RID: 37283
		[Token(Token = "0x40091A3")]
		[FieldOffset(Offset = "0x78")]
		public UILabel matchText;

		// Token: 0x040091A4 RID: 37284
		[Token(Token = "0x40091A4")]
		[FieldOffset(Offset = "0x80")]
		public UISprite tweenTopBg;

		// Token: 0x040091A5 RID: 37285
		[Token(Token = "0x40091A5")]
		[FieldOffset(Offset = "0x88")]
		private TweenPosition TopTween;

		// Token: 0x040091A6 RID: 37286
		[Token(Token = "0x40091A6")]
		[FieldOffset(Offset = "0x90")]
		public UISprite tweenBottomBg;

		// Token: 0x040091A7 RID: 37287
		[Token(Token = "0x40091A7")]
		[FieldOffset(Offset = "0x98")]
		private TweenPosition bottomTween;

		// Token: 0x040091A8 RID: 37288
		[Token(Token = "0x40091A8")]
		[FieldOffset(Offset = "0xA0")]
		public Transform uiRoot;

		// Token: 0x040091A9 RID: 37289
		[Token(Token = "0x40091A9")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject animSprite;

		// Token: 0x040091AA RID: 37290
		[Token(Token = "0x40091AA")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject startEffect;

		// Token: 0x040091AB RID: 37291
		[Token(Token = "0x40091AB")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject endEffect;

		// Token: 0x040091AC RID: 37292
		[Token(Token = "0x40091AC")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject rankingText;

		// Token: 0x040091AD RID: 37293
		[Token(Token = "0x40091AD")]
		[FieldOffset(Offset = "0xC8")]
		private UILabel[] m_Labels;

		// Token: 0x040091AE RID: 37294
		[Token(Token = "0x40091AE")]
		[FieldOffset(Offset = "0xD0")]
		private TypewriterEffect[] m_Writers;

		// Token: 0x040091AF RID: 37295
		[Token(Token = "0x40091AF")]
		[FieldOffset(Offset = "0xD8")]
		private int m_WriterIndex;

		// Token: 0x040091B0 RID: 37296
		[Token(Token = "0x40091B0")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_DelayCallId;

		// Token: 0x040091B1 RID: 37297
		[Token(Token = "0x40091B1")]
		[FieldOffset(Offset = "0xE0")]
		private AudioResource m_TypeWriterSound;

		// Token: 0x020018C6 RID: 6342
		[Token(Token = "0x20018C6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F4CEC", Offset = "0x10F4CEC")]
		private sealed class <ShowAnimSprite>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007E4E RID: 32334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E4E")]
			[Address(RVA = "0x1C1254C", Offset = "0x1C1254C", VA = "0x7BBC41254C")]
			[DebuggerHidden]
			public <ShowAnimSprite>d__24(int <>1__state)
			{
			}

			// Token: 0x06007E4F RID: 32335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E4F")]
			[Address(RVA = "0x1C12CDC", Offset = "0x1C12CDC", VA = "0x7BBC412CDC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007E50 RID: 32336 RVA: 0x000228A8 File Offset: 0x00020AA8
			[Token(Token = "0x6007E50")]
			[Address(RVA = "0x1C12CE0", Offset = "0x1C12CE0", VA = "0x7BBC412CE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x06007E51 RID: 32337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000996")]
			private object Current
			{
				[Token(Token = "0x6007E51")]
				[Address(RVA = "0x1C12DA8", Offset = "0x1C12DA8", VA = "0x7BBC412DA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007E52 RID: 32338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E52")]
			[Address(RVA = "0x1C12DB0", Offset = "0x1C12DB0", VA = "0x7BBC412DB0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x06007E53 RID: 32339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000997")]
			private object Current
			{
				[Token(Token = "0x6007E53")]
				[Address(RVA = "0x1C12E18", Offset = "0x1C12E18", VA = "0x7BBC412E18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040091B2 RID: 37298
			[Token(Token = "0x40091B2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040091B3 RID: 37299
			[Token(Token = "0x40091B3")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040091B4 RID: 37300
			[Token(Token = "0x40091B4")]
			[FieldOffset(Offset = "0x20")]
			public UIHudGameOpeningManager <>4__this;
		}
	}
}
