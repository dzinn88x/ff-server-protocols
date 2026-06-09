using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015E6 RID: 5606
	[Token(Token = "0x20015E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF54C", Offset = "0x10EF54C")]
	public class UIHudLadderMatchResultController : UIPopupWindowController
	{
		// Token: 0x06006381 RID: 25473 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[Token(Token = "0x6006381")]
		[Address(RVA = "0x1C545E4", Offset = "0x1C545E4", VA = "0x7BBC4545E4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006382")]
		[Address(RVA = "0x1C54634", Offset = "0x1C54634", VA = "0x7BBC454634")]
		public void SetResultData(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006383")]
		[Address(RVA = "0x1C561B0", Offset = "0x1C561B0", VA = "0x7BBC4561B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006384")]
		[Address(RVA = "0x1C56324", Offset = "0x1C56324", VA = "0x7BBC456324", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006385")]
		[Address(RVA = "0x1C56458", Offset = "0x1C56458", VA = "0x7BBC456458", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		[Token(Token = "0x6006386")]
		[Address(RVA = "0x1C56500", Offset = "0x1C56500", VA = "0x7BBC456500", Slot = "30")]
		public override int GlassDelay()
		{
			return 0;
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006387")]
		[Address(RVA = "0x1C56508", Offset = "0x1C56508", VA = "0x7BBC456508")]
		private void OnClickMask()
		{
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006388")]
		[Address(RVA = "0x1C5651C", Offset = "0x1C5651C", VA = "0x7BBC45651C")]
		private void OnClickTokenDetail()
		{
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006389")]
		[Address(RVA = "0x1C546B8", Offset = "0x1C546B8", VA = "0x7BBC4546B8")]
		private void InitRankInfo(MatchIncome income)
		{
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638A")]
		[Address(RVA = "0x1C55398", Offset = "0x1C55398", VA = "0x7BBC455398")]
		private void InitScoreInfo(MatchIncome income, uint rank)
		{
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638B")]
		[Address(RVA = "0x1C5582C", Offset = "0x1C5582C", VA = "0x7BBC45582C")]
		private void InitTokenInfo(MatchIncome income)
		{
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638C")]
		[Address(RVA = "0x1C55B08", Offset = "0x1C55B08", VA = "0x7BBC455B08")]
		private void InitSurvivalTimeInfo(MatchStats stats)
		{
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638D")]
		[Address(RVA = "0x1C55CAC", Offset = "0x1C55CAC", VA = "0x7BBC455CAC")]
		private void InitBonusInfo(MatchIncome income)
		{
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600638E")]
		[Address(RVA = "0x1C5613C", Offset = "0x1C5613C", VA = "0x7BBC45613C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11401DC", Offset = "0x11401DC")]
		private IEnumerator StartLadderResultAnimation()
		{
			return null;
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600638F")]
		[Address(RVA = "0x1C567BC", Offset = "0x1C567BC", VA = "0x7BBC4567BC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140240", Offset = "0x1140240")]
		private IEnumerator PlayScoreAnimation()
		{
			return null;
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006390")]
		[Address(RVA = "0x1C56830", Offset = "0x1C56830", VA = "0x7BBC456830")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11402A4", Offset = "0x11402A4")]
		private IEnumerator PlayProgressAnimation(UIHudLadderMatchResultController.ProgressInfo info)
		{
			return null;
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006391")]
		[Address(RVA = "0x1C568E0", Offset = "0x1C568E0", VA = "0x7BBC4568E0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140308", Offset = "0x1140308")]
		private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
		{
			return null;
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006392")]
		[Address(RVA = "0x1C56978", Offset = "0x1C56978", VA = "0x7BBC456978")]
		public UIHudLadderMatchResultController()
		{
		}

		// Token: 0x04008236 RID: 33334
		[Token(Token = "0x4008236")]
		[FieldOffset(Offset = "0x98")]
		private UIHudLadderMatchResultView m_View;

		// Token: 0x04008237 RID: 33335
		[Token(Token = "0x4008237")]
		private const int SCORE_ADD_NUM = 1;

		// Token: 0x04008238 RID: 33336
		[Token(Token = "0x4008238")]
		private const float PROGRESS_ANIM_SPEED_1 = 2f;

		// Token: 0x04008239 RID: 33337
		[Token(Token = "0x4008239")]
		private const float PROGRESS_ANIM_SPEED_2 = 4f;

		// Token: 0x0400823A RID: 33338
		[Token(Token = "0x400823A")]
		private const uint PROGRESS_OFFSET = 30U;

		// Token: 0x0400823B RID: 33339
		[Token(Token = "0x400823B")]
		private const string ANIMATION_ENTER = "UILadderMatchEnterAnim";

		// Token: 0x0400823C RID: 33340
		[Token(Token = "0x400823C")]
		private const string ANIMATION_RANK_UP = "UILadderMatchRankUp";

		// Token: 0x0400823D RID: 33341
		[Token(Token = "0x400823D")]
		private const string ANIMATION_RANK_DOWN = "UILadderMatchRankDown";

		// Token: 0x0400823E RID: 33342
		[Token(Token = "0x400823E")]
		[FieldOffset(Offset = "0xA0")]
		private int DeltaPoint;

		// Token: 0x0400823F RID: 33343
		[Token(Token = "0x400823F")]
		[FieldOffset(Offset = "0xA8")]
		private string DeltaStr;

		// Token: 0x04008240 RID: 33344
		[Token(Token = "0x4008240")]
		[FieldOffset(Offset = "0xB0")]
		private uint TokenMax;

		// Token: 0x04008241 RID: 33345
		[Token(Token = "0x4008241")]
		[FieldOffset(Offset = "0xB4")]
		private int BeforePoint;

		// Token: 0x04008242 RID: 33346
		[Token(Token = "0x4008242")]
		[FieldOffset(Offset = "0xB8")]
		private uint BeforeRank;

		// Token: 0x04008243 RID: 33347
		[Token(Token = "0x4008243")]
		[FieldOffset(Offset = "0xBC")]
		private float BeforeProgressValue;

		// Token: 0x04008244 RID: 33348
		[Token(Token = "0x4008244")]
		[FieldOffset(Offset = "0xC0")]
		private LadderLevelData BeforeLevelData;

		// Token: 0x04008245 RID: 33349
		[Token(Token = "0x4008245")]
		[FieldOffset(Offset = "0xC8")]
		private bool IsBeforeMaxRank;

		// Token: 0x04008246 RID: 33350
		[Token(Token = "0x4008246")]
		[FieldOffset(Offset = "0xC9")]
		private bool IsBeforePeakRank;

		// Token: 0x04008247 RID: 33351
		[Token(Token = "0x4008247")]
		[FieldOffset(Offset = "0xCC")]
		private int AfterPoint;

		// Token: 0x04008248 RID: 33352
		[Token(Token = "0x4008248")]
		[FieldOffset(Offset = "0xD0")]
		private uint AfterRank;

		// Token: 0x04008249 RID: 33353
		[Token(Token = "0x4008249")]
		[FieldOffset(Offset = "0xD4")]
		private float AfterProgressValue;

		// Token: 0x0400824A RID: 33354
		[Token(Token = "0x400824A")]
		[FieldOffset(Offset = "0xD8")]
		private LadderLevelData AfterLevelData;

		// Token: 0x0400824B RID: 33355
		[Token(Token = "0x400824B")]
		[FieldOffset(Offset = "0xE0")]
		private bool IsAfterMaxRank;

		// Token: 0x0400824C RID: 33356
		[Token(Token = "0x400824C")]
		[FieldOffset(Offset = "0xE1")]
		private bool IsAfterPeakRank;

		// Token: 0x0400824D RID: 33357
		[Token(Token = "0x400824D")]
		[FieldOffset(Offset = "0xE2")]
		private bool CanCloseFlag;

		// Token: 0x0400824E RID: 33358
		[Token(Token = "0x400824E")]
		[FieldOffset(Offset = "0xE8")]
		private PeakRankData CurrentPeakData;

		// Token: 0x0400824F RID: 33359
		[Token(Token = "0x400824F")]
		[FieldOffset(Offset = "0xF0")]
		private UIHudCommonlTipsController m_TokenTipCtrl;

		// Token: 0x020015E7 RID: 5607
		[Token(Token = "0x20015E7")]
		private struct ProgressInfo
		{
			// Token: 0x04008250 RID: 33360
			[Token(Token = "0x4008250")]
			[FieldOffset(Offset = "0x0")]
			public float CurPercentage;

			// Token: 0x04008251 RID: 33361
			[Token(Token = "0x4008251")]
			[FieldOffset(Offset = "0x4")]
			public float StartProgressValue;

			// Token: 0x04008252 RID: 33362
			[Token(Token = "0x4008252")]
			[FieldOffset(Offset = "0x8")]
			public float EndProgressValue;

			// Token: 0x04008253 RID: 33363
			[Token(Token = "0x4008253")]
			[FieldOffset(Offset = "0xC")]
			public float speedValue;
		}

		// Token: 0x020015E8 RID: 5608
		[Token(Token = "0x20015E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF584", Offset = "0x10EF584")]
		private sealed class <StartLadderResultAnimation>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006393 RID: 25491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006393")]
			[Address(RVA = "0x15B6FF8", Offset = "0x15B6FF8", VA = "0x7BBBDB6FF8")]
			[DebuggerHidden]
			public <StartLadderResultAnimation>d__40(int <>1__state)
			{
			}

			// Token: 0x06006394 RID: 25492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006394")]
			[Address(RVA = "0x15B7024", Offset = "0x15B7024", VA = "0x7BBBDB7024", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006395 RID: 25493 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
			[Token(Token = "0x6006395")]
			[Address(RVA = "0x15B7028", Offset = "0x15B7028", VA = "0x7BBBDB7028", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06006396 RID: 25494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008DB")]
			private object Current
			{
				[Token(Token = "0x6006396")]
				[Address(RVA = "0x15B7700", Offset = "0x15B7700", VA = "0x7BBBDB7700", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006397 RID: 25495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006397")]
			[Address(RVA = "0x15B7708", Offset = "0x15B7708", VA = "0x7BBBDB7708", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06006398 RID: 25496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008DC")]
			private object Current
			{
				[Token(Token = "0x6006398")]
				[Address(RVA = "0x15B7770", Offset = "0x15B7770", VA = "0x7BBBDB7770", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008254 RID: 33364
			[Token(Token = "0x4008254")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008255 RID: 33365
			[Token(Token = "0x4008255")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008256 RID: 33366
			[Token(Token = "0x4008256")]
			[FieldOffset(Offset = "0x20")]
			public UIHudLadderMatchResultController <>4__this;

			// Token: 0x04008257 RID: 33367
			[Token(Token = "0x4008257")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;
		}

		// Token: 0x020015E9 RID: 5609
		[Token(Token = "0x20015E9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF594", Offset = "0x10EF594")]
		private sealed class <PlayScoreAnimation>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006399 RID: 25497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006399")]
			[Address(RVA = "0x15B6D9C", Offset = "0x15B6D9C", VA = "0x7BBBDB6D9C")]
			[DebuggerHidden]
			public <PlayScoreAnimation>d__41(int <>1__state)
			{
			}

			// Token: 0x0600639A RID: 25498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600639A")]
			[Address(RVA = "0x15B6DC8", Offset = "0x15B6DC8", VA = "0x7BBBDB6DC8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600639B RID: 25499 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
			[Token(Token = "0x600639B")]
			[Address(RVA = "0x15B6DCC", Offset = "0x15B6DCC", VA = "0x7BBBDB6DCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x0600639C RID: 25500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008DD")]
			private object Current
			{
				[Token(Token = "0x600639C")]
				[Address(RVA = "0x15B6F80", Offset = "0x15B6F80", VA = "0x7BBBDB6F80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600639D RID: 25501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600639D")]
			[Address(RVA = "0x15B6F88", Offset = "0x15B6F88", VA = "0x7BBBDB6F88", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x0600639E RID: 25502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008DE")]
			private object Current
			{
				[Token(Token = "0x600639E")]
				[Address(RVA = "0x15B6FF0", Offset = "0x15B6FF0", VA = "0x7BBBDB6FF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008258 RID: 33368
			[Token(Token = "0x4008258")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008259 RID: 33369
			[Token(Token = "0x4008259")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400825A RID: 33370
			[Token(Token = "0x400825A")]
			[FieldOffset(Offset = "0x20")]
			public UIHudLadderMatchResultController <>4__this;

			// Token: 0x0400825B RID: 33371
			[Token(Token = "0x400825B")]
			[FieldOffset(Offset = "0x28")]
			private int <num>5__2;
		}

		// Token: 0x020015EA RID: 5610
		[Token(Token = "0x20015EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF5A4", Offset = "0x10EF5A4")]
		private sealed class <PlayProgressAnimation>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600639F RID: 25503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600639F")]
			[Address(RVA = "0x15B6988", Offset = "0x15B6988", VA = "0x7BBBDB6988")]
			[DebuggerHidden]
			public <PlayProgressAnimation>d__42(int <>1__state)
			{
			}

			// Token: 0x060063A0 RID: 25504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063A0")]
			[Address(RVA = "0x15B69B4", Offset = "0x15B69B4", VA = "0x7BBBDB69B4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060063A1 RID: 25505 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
			[Token(Token = "0x60063A1")]
			[Address(RVA = "0x15B69B8", Offset = "0x15B69B8", VA = "0x7BBBDB69B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x060063A2 RID: 25506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008DF")]
			private object Current
			{
				[Token(Token = "0x60063A2")]
				[Address(RVA = "0x15B6D24", Offset = "0x15B6D24", VA = "0x7BBBDB6D24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060063A3 RID: 25507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063A3")]
			[Address(RVA = "0x15B6D2C", Offset = "0x15B6D2C", VA = "0x7BBBDB6D2C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x060063A4 RID: 25508 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008E0")]
			private object Current
			{
				[Token(Token = "0x60063A4")]
				[Address(RVA = "0x15B6D94", Offset = "0x15B6D94", VA = "0x7BBBDB6D94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400825C RID: 33372
			[Token(Token = "0x400825C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400825D RID: 33373
			[Token(Token = "0x400825D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400825E RID: 33374
			[Token(Token = "0x400825E")]
			[FieldOffset(Offset = "0x20")]
			public UIHudLadderMatchResultController.ProgressInfo info;

			// Token: 0x0400825F RID: 33375
			[Token(Token = "0x400825F")]
			[FieldOffset(Offset = "0x30")]
			public UIHudLadderMatchResultController <>4__this;
		}

		// Token: 0x020015EB RID: 5611
		[Token(Token = "0x20015EB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF5B4", Offset = "0x10EF5B4")]
		private sealed class <PlayAndWaitingForAnimationOver>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060063A5 RID: 25509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063A5")]
			[Address(RVA = "0x15B6754", Offset = "0x15B6754", VA = "0x7BBBDB6754")]
			[DebuggerHidden]
			public <PlayAndWaitingForAnimationOver>d__43(int <>1__state)
			{
			}

			// Token: 0x060063A6 RID: 25510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063A6")]
			[Address(RVA = "0x15B6780", Offset = "0x15B6780", VA = "0x7BBBDB6780", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060063A7 RID: 25511 RVA: 0x0001CB00 File Offset: 0x0001AD00
			[Token(Token = "0x60063A7")]
			[Address(RVA = "0x15B6784", Offset = "0x15B6784", VA = "0x7BBBDB6784", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x060063A8 RID: 25512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008E1")]
			private object Current
			{
				[Token(Token = "0x60063A8")]
				[Address(RVA = "0x15B6910", Offset = "0x15B6910", VA = "0x7BBBDB6910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060063A9 RID: 25513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60063A9")]
			[Address(RVA = "0x15B6918", Offset = "0x15B6918", VA = "0x7BBBDB6918", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x060063AA RID: 25514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008E2")]
			private object Current
			{
				[Token(Token = "0x60063AA")]
				[Address(RVA = "0x15B6980", Offset = "0x15B6980", VA = "0x7BBBDB6980", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008260 RID: 33376
			[Token(Token = "0x4008260")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008261 RID: 33377
			[Token(Token = "0x4008261")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008262 RID: 33378
			[Token(Token = "0x4008262")]
			[FieldOffset(Offset = "0x20")]
			public Animation animationCom;

			// Token: 0x04008263 RID: 33379
			[Token(Token = "0x4008263")]
			[FieldOffset(Offset = "0x28")]
			public string animation;

			// Token: 0x04008264 RID: 33380
			[Token(Token = "0x4008264")]
			[FieldOffset(Offset = "0x30")]
			private float <aniamtionTime>5__2;
		}
	}
}
