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
	// Token: 0x020015E1 RID: 5601
	[Token(Token = "0x20015E1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF4D4", Offset = "0x10EF4D4")]
	public class UIHudCSLadderMatchResultController : UIPopupWindowController
	{
		// Token: 0x0600635B RID: 25435 RVA: 0x0001CA10 File Offset: 0x0001AC10
		[Token(Token = "0x600635B")]
		[Address(RVA = "0x19BAB58", Offset = "0x19BAB58", VA = "0x7BBC1BAB58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635C")]
		[Address(RVA = "0x19BABA8", Offset = "0x19BABA8", VA = "0x7BBC1BABA8")]
		public void SetResultData(MatchIncome incomeData, MatchStats statsData)
		{
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635D")]
		[Address(RVA = "0x19BB9C0", Offset = "0x19BB9C0", VA = "0x7BBC1BB9C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635E")]
		[Address(RVA = "0x19BBB04", Offset = "0x19BBB04", VA = "0x7BBC1BBB04", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600635F")]
		[Address(RVA = "0x19BBCD8", Offset = "0x19BBCD8", VA = "0x7BBC1BBCD8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006360")]
		[Address(RVA = "0x19BBCE0", Offset = "0x19BBCE0", VA = "0x7BBC1BBCE0")]
		private void OnMaskClick()
		{
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006361")]
		[Address(RVA = "0x19BBD08", Offset = "0x19BBD08", VA = "0x7BBC1BBD08")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FF0C", Offset = "0x113FF0C")]
		private IEnumerator PlayUpStarAnim(LadderMatchStarGroup currentStarGroup)
		{
			return null;
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006362")]
		[Address(RVA = "0x19BBDCC", Offset = "0x19BBDCC", VA = "0x7BBC1BBDCC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FF70", Offset = "0x113FF70")]
		private IEnumerator PlayLoseStarAnim(LadderMatchStarGroup currentStarGroup)
		{
			return null;
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006363")]
		[Address(RVA = "0x19BB94C", Offset = "0x19BB94C", VA = "0x7BBC1BB94C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FFD4", Offset = "0x113FFD4")]
		private IEnumerator StartLadderResultAnimation()
		{
			return null;
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006364")]
		[Address(RVA = "0x19BBEBC", Offset = "0x19BBEBC", VA = "0x7BBC1BBEBC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140038", Offset = "0x1140038")]
		private IEnumerator PlayAndWaitingForAnimationOver(Animation animationCom, string animation)
		{
			return null;
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006365")]
		[Address(RVA = "0x19BB4F0", Offset = "0x19BB4F0", VA = "0x7BBC1BB4F0")]
		private void SetScoreInfoPanel()
		{
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006366")]
		[Address(RVA = "0x19BAD78", Offset = "0x19BAD78", VA = "0x7BBC1BAD78")]
		private void SetOldRankUIGroup()
		{
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006367")]
		[Address(RVA = "0x19BB118", Offset = "0x19BB118", VA = "0x7BBC1BB118")]
		private void SetCurrentRankUIGroup()
		{
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006368")]
		[Address(RVA = "0x19BBF98", Offset = "0x19BBF98", VA = "0x7BBC1BBF98")]
		public UIHudCSLadderMatchResultController()
		{
		}

		// Token: 0x0400820B RID: 33291
		[Token(Token = "0x400820B")]
		[FieldOffset(Offset = "0x98")]
		private UIHudCSLadderMatchResultView m_View;

		// Token: 0x0400820C RID: 33292
		[Token(Token = "0x400820C")]
		private const string ANIMATION_ENTER = "UILadderCSMatchEnterAnim";

		// Token: 0x0400820D RID: 33293
		[Token(Token = "0x400820D")]
		private const string ANIMATION_RANK_UP = "UILadderCSMatchRankUp";

		// Token: 0x0400820E RID: 33294
		[Token(Token = "0x400820E")]
		private const string ANIMATION_RANK_DOWN = "UILadderCSMatchRankDown";

		// Token: 0x0400820F RID: 33295
		[Token(Token = "0x400820F")]
		private const string ANIMATION_SCOREINFO = "UILadderCSMatchScoreInfoEnter";

		// Token: 0x04008210 RID: 33296
		[Token(Token = "0x4008210")]
		private const float RANK_UPDATE_WAIT_TIME = 0.1f;

		// Token: 0x04008211 RID: 33297
		[Token(Token = "0x4008211")]
		private const uint MAX_PROTECT_POINT = 100U;

		// Token: 0x04008212 RID: 33298
		[Token(Token = "0x4008212")]
		[FieldOffset(Offset = "0xA0")]
		private bool IsWin;

		// Token: 0x04008213 RID: 33299
		[Token(Token = "0x4008213")]
		[FieldOffset(Offset = "0xA4")]
		private int RankBefore;

		// Token: 0x04008214 RID: 33300
		[Token(Token = "0x4008214")]
		[FieldOffset(Offset = "0xA8")]
		private int RankAfter;

		// Token: 0x04008215 RID: 33301
		[Token(Token = "0x4008215")]
		[FieldOffset(Offset = "0xAC")]
		private int PointsBefore;

		// Token: 0x04008216 RID: 33302
		[Token(Token = "0x4008216")]
		[FieldOffset(Offset = "0xB0")]
		private int PointsAfter;

		// Token: 0x04008217 RID: 33303
		[Token(Token = "0x4008217")]
		[FieldOffset(Offset = "0xB4")]
		private uint PreProtect;

		// Token: 0x04008218 RID: 33304
		[Token(Token = "0x4008218")]
		[FieldOffset(Offset = "0xB8")]
		private uint CurProtect;

		// Token: 0x04008219 RID: 33305
		[Token(Token = "0x4008219")]
		[FieldOffset(Offset = "0xC0")]
		private CSRankData CurrentLevelData;

		// Token: 0x0400821A RID: 33306
		[Token(Token = "0x400821A")]
		[FieldOffset(Offset = "0xC8")]
		private CSRankData OldLevelData;

		// Token: 0x0400821B RID: 33307
		[Token(Token = "0x400821B")]
		[FieldOffset(Offset = "0xD0")]
		private LadderMatchStarGroup StarGroupBefore;

		// Token: 0x0400821C RID: 33308
		[Token(Token = "0x400821C")]
		[FieldOffset(Offset = "0xD8")]
		private LadderMatchStarGroup StarGroupAfter;

		// Token: 0x0400821D RID: 33309
		[Token(Token = "0x400821D")]
		[FieldOffset(Offset = "0xE0")]
		private bool CanCloseFlag;

		// Token: 0x0400821E RID: 33310
		[Token(Token = "0x400821E")]
		[FieldOffset(Offset = "0xE4")]
		private int CurAnimSpeed;

		// Token: 0x0400821F RID: 33311
		[Token(Token = "0x400821F")]
		[FieldOffset(Offset = "0xE8")]
		private bool IsInProtect;

		// Token: 0x020015E2 RID: 5602
		[Token(Token = "0x20015E2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF50C", Offset = "0x10EF50C")]
		private sealed class <PlayUpStarAnim>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006369 RID: 25449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006369")]
			[Address(RVA = "0x19BBDA0", Offset = "0x19BBDA0", VA = "0x7BBC1BBDA0")]
			[DebuggerHidden]
			public <PlayUpStarAnim>d__27(int <>1__state)
			{
			}

			// Token: 0x0600636A RID: 25450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600636A")]
			[Address(RVA = "0x19BC3E8", Offset = "0x19BC3E8", VA = "0x7BBC1BC3E8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600636B RID: 25451 RVA: 0x0001CA28 File Offset: 0x0001AC28
			[Token(Token = "0x600636B")]
			[Address(RVA = "0x19BC3EC", Offset = "0x19BC3EC", VA = "0x7BBC1BC3EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008D3 RID: 2259
			// (get) Token: 0x0600636C RID: 25452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D3")]
			private object Current
			{
				[Token(Token = "0x600636C")]
				[Address(RVA = "0x19BC54C", Offset = "0x19BC54C", VA = "0x7BBC1BC54C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600636D RID: 25453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600636D")]
			[Address(RVA = "0x19BC554", Offset = "0x19BC554", VA = "0x7BBC1BC554", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008D4 RID: 2260
			// (get) Token: 0x0600636E RID: 25454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D4")]
			private object Current
			{
				[Token(Token = "0x600636E")]
				[Address(RVA = "0x19BC5BC", Offset = "0x19BC5BC", VA = "0x7BBC1BC5BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008220 RID: 33312
			[Token(Token = "0x4008220")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008221 RID: 33313
			[Token(Token = "0x4008221")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008222 RID: 33314
			[Token(Token = "0x4008222")]
			[FieldOffset(Offset = "0x20")]
			public LadderMatchStarGroup currentStarGroup;

			// Token: 0x04008223 RID: 33315
			[Token(Token = "0x4008223")]
			[FieldOffset(Offset = "0x28")]
			public UIHudCSLadderMatchResultController <>4__this;
		}

		// Token: 0x020015E3 RID: 5603
		[Token(Token = "0x20015E3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF51C", Offset = "0x10EF51C")]
		private sealed class <PlayLoseStarAnim>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600636F RID: 25455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600636F")]
			[Address(RVA = "0x19BBE64", Offset = "0x19BBE64", VA = "0x7BBC1BBE64")]
			[DebuggerHidden]
			public <PlayLoseStarAnim>d__28(int <>1__state)
			{
			}

			// Token: 0x06006370 RID: 25456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006370")]
			[Address(RVA = "0x19BC20C", Offset = "0x19BC20C", VA = "0x7BBC1BC20C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006371 RID: 25457 RVA: 0x0001CA40 File Offset: 0x0001AC40
			[Token(Token = "0x6006371")]
			[Address(RVA = "0x19BC210", Offset = "0x19BC210", VA = "0x7BBC1BC210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008D5 RID: 2261
			// (get) Token: 0x06006372 RID: 25458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D5")]
			private object Current
			{
				[Token(Token = "0x6006372")]
				[Address(RVA = "0x19BC370", Offset = "0x19BC370", VA = "0x7BBC1BC370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006373 RID: 25459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006373")]
			[Address(RVA = "0x19BC378", Offset = "0x19BC378", VA = "0x7BBC1BC378", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008D6 RID: 2262
			// (get) Token: 0x06006374 RID: 25460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D6")]
			private object Current
			{
				[Token(Token = "0x6006374")]
				[Address(RVA = "0x19BC3E0", Offset = "0x19BC3E0", VA = "0x7BBC1BC3E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008224 RID: 33316
			[Token(Token = "0x4008224")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008225 RID: 33317
			[Token(Token = "0x4008225")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008226 RID: 33318
			[Token(Token = "0x4008226")]
			[FieldOffset(Offset = "0x20")]
			public LadderMatchStarGroup currentStarGroup;

			// Token: 0x04008227 RID: 33319
			[Token(Token = "0x4008227")]
			[FieldOffset(Offset = "0x28")]
			public UIHudCSLadderMatchResultController <>4__this;
		}

		// Token: 0x020015E4 RID: 5604
		[Token(Token = "0x20015E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF52C", Offset = "0x10EF52C")]
		private sealed class <StartLadderResultAnimation>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006375 RID: 25461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006375")]
			[Address(RVA = "0x19BBE90", Offset = "0x19BBE90", VA = "0x7BBC1BBE90")]
			[DebuggerHidden]
			public <StartLadderResultAnimation>d__29(int <>1__state)
			{
			}

			// Token: 0x06006376 RID: 25462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006376")]
			[Address(RVA = "0x19BC5C4", Offset = "0x19BC5C4", VA = "0x7BBC1BC5C4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006377 RID: 25463 RVA: 0x0001CA58 File Offset: 0x0001AC58
			[Token(Token = "0x6006377")]
			[Address(RVA = "0x19BC5C8", Offset = "0x19BC5C8", VA = "0x7BBC1BC5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008D7 RID: 2263
			// (get) Token: 0x06006378 RID: 25464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D7")]
			private object Current
			{
				[Token(Token = "0x6006378")]
				[Address(RVA = "0x19BCF2C", Offset = "0x19BCF2C", VA = "0x7BBC1BCF2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006379 RID: 25465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006379")]
			[Address(RVA = "0x19BCF34", Offset = "0x19BCF34", VA = "0x7BBC1BCF34", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008D8 RID: 2264
			// (get) Token: 0x0600637A RID: 25466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D8")]
			private object Current
			{
				[Token(Token = "0x600637A")]
				[Address(RVA = "0x19BCF9C", Offset = "0x19BCF9C", VA = "0x7BBC1BCF9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008228 RID: 33320
			[Token(Token = "0x4008228")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008229 RID: 33321
			[Token(Token = "0x4008229")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400822A RID: 33322
			[Token(Token = "0x400822A")]
			[FieldOffset(Offset = "0x20")]
			public UIHudCSLadderMatchResultController <>4__this;

			// Token: 0x0400822B RID: 33323
			[Token(Token = "0x400822B")]
			[FieldOffset(Offset = "0x28")]
			private int <pointsDelta>5__2;

			// Token: 0x0400822C RID: 33324
			[Token(Token = "0x400822C")]
			[FieldOffset(Offset = "0x2C")]
			private bool <isUpStar>5__3;

			// Token: 0x0400822D RID: 33325
			[Token(Token = "0x400822D")]
			[FieldOffset(Offset = "0x2D")]
			private bool <isLevelChange>5__4;

			// Token: 0x0400822E RID: 33326
			[Token(Token = "0x400822E")]
			[FieldOffset(Offset = "0x30")]
			private LadderMatchStarGroup <currentStarGroup>5__5;

			// Token: 0x0400822F RID: 33327
			[Token(Token = "0x400822F")]
			[FieldOffset(Offset = "0x38")]
			private int <star>5__6;
		}

		// Token: 0x020015E5 RID: 5605
		[Token(Token = "0x20015E5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF53C", Offset = "0x10EF53C")]
		private sealed class <PlayAndWaitingForAnimationOver>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600637B RID: 25467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600637B")]
			[Address(RVA = "0x19BBF6C", Offset = "0x19BBF6C", VA = "0x7BBC1BBF6C")]
			[DebuggerHidden]
			public <PlayAndWaitingForAnimationOver>d__30(int <>1__state)
			{
			}

			// Token: 0x0600637C RID: 25468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600637C")]
			[Address(RVA = "0x19BBFA8", Offset = "0x19BBFA8", VA = "0x7BBC1BBFA8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600637D RID: 25469 RVA: 0x0001CA70 File Offset: 0x0001AC70
			[Token(Token = "0x600637D")]
			[Address(RVA = "0x19BBFAC", Offset = "0x19BBFAC", VA = "0x7BBC1BBFAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008D9 RID: 2265
			// (get) Token: 0x0600637E RID: 25470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008D9")]
			private object Current
			{
				[Token(Token = "0x600637E")]
				[Address(RVA = "0x19BC194", Offset = "0x19BC194", VA = "0x7BBC1BC194", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600637F RID: 25471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600637F")]
			[Address(RVA = "0x19BC19C", Offset = "0x19BC19C", VA = "0x7BBC1BC19C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06006380 RID: 25472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008DA")]
			private object Current
			{
				[Token(Token = "0x6006380")]
				[Address(RVA = "0x19BC204", Offset = "0x19BC204", VA = "0x7BBC1BC204", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008230 RID: 33328
			[Token(Token = "0x4008230")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008231 RID: 33329
			[Token(Token = "0x4008231")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008232 RID: 33330
			[Token(Token = "0x4008232")]
			[FieldOffset(Offset = "0x20")]
			public Animation animationCom;

			// Token: 0x04008233 RID: 33331
			[Token(Token = "0x4008233")]
			[FieldOffset(Offset = "0x28")]
			public string animation;

			// Token: 0x04008234 RID: 33332
			[Token(Token = "0x4008234")]
			[FieldOffset(Offset = "0x30")]
			public UIHudCSLadderMatchResultController <>4__this;

			// Token: 0x04008235 RID: 33333
			[Token(Token = "0x4008235")]
			[FieldOffset(Offset = "0x38")]
			private float <aniamtionTime>5__2;
		}
	}
}
