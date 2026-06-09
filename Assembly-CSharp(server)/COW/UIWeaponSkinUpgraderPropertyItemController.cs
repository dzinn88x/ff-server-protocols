using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BEB RID: 7147
	[Token(Token = "0x2001BEB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB24C", Offset = "0x10FB24C")]
	public class UIWeaponSkinUpgraderPropertyItemController : UIBaseController
	{
		// Token: 0x06009B29 RID: 39721 RVA: 0x00028C68 File Offset: 0x00026E68
		[Token(Token = "0x6009B29")]
		[Address(RVA = "0x2231184", Offset = "0x2231184", VA = "0x7BBCA31184")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B2A")]
		[Address(RVA = "0x22311D4", Offset = "0x22311D4", VA = "0x7BBCA311D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B2B")]
		[Address(RVA = "0x2231394", Offset = "0x2231394", VA = "0x7BBCA31394", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B2C")]
		[Address(RVA = "0x2225FB8", Offset = "0x2225FB8", VA = "0x7BBCA25FB8")]
		public void SetData(WeaponSkinFeature feature, WSUPropertyType type)
		{
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B2D")]
		[Address(RVA = "0x2231688", Offset = "0x2231688", VA = "0x7BBCA31688")]
		private void ShowSkinProperty()
		{
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B2E")]
		[Address(RVA = "0x2231830", Offset = "0x2231830", VA = "0x7BBCA31830")]
		private void OnShowProperty(object[] data)
		{
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B2F")]
		[Address(RVA = "0x22318E8", Offset = "0x22318E8", VA = "0x7BBCA318E8")]
		private void OnChosen()
		{
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B30")]
		[Address(RVA = "0x223147C", Offset = "0x223147C", VA = "0x7BBCA3147C")]
		private void OnUnChosen()
		{
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B31")]
		[Address(RVA = "0x2231B04", Offset = "0x2231B04", VA = "0x7BBCA31B04")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1145170", Offset = "0x1145170")]
		private IEnumerator MoveToTargetX(float targetX)
		{
			return null;
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B32")]
		[Address(RVA = "0x2231BC8", Offset = "0x2231BC8", VA = "0x7BBCA31BC8")]
		public UIWeaponSkinUpgraderPropertyItemController()
		{
		}

		// Token: 0x0400A19D RID: 41373
		[Token(Token = "0x400A19D")]
		[FieldOffset(Offset = "0x58")]
		private UIWeaponSkinUpgraderPropertyItemView m_View;

		// Token: 0x0400A19E RID: 41374
		[Token(Token = "0x400A19E")]
		[FieldOffset(Offset = "0x60")]
		private WeaponSkinUpgradeInfoData m_FeatureInfo;

		// Token: 0x0400A19F RID: 41375
		[Token(Token = "0x400A19F")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsChosen;

		// Token: 0x0400A1A0 RID: 41376
		[Token(Token = "0x400A1A0")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine m_ChosenMoveCoroutine;

		// Token: 0x0400A1A1 RID: 41377
		[Token(Token = "0x400A1A1")]
		[FieldOffset(Offset = "0x78")]
		private WSUPropertyType m_Type;

		// Token: 0x0400A1A2 RID: 41378
		[Token(Token = "0x400A1A2")]
		private const float m_UnchosenX = 0f;

		// Token: 0x0400A1A3 RID: 41379
		[Token(Token = "0x400A1A3")]
		private const float m_ChosenX = -8f;

		// Token: 0x02001BEC RID: 7148
		[Token(Token = "0x2001BEC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB284", Offset = "0x10FB284")]
		private sealed class <MoveToTargetX>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06009B33 RID: 39731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009B33")]
			[Address(RVA = "0x2231B9C", Offset = "0x2231B9C", VA = "0x7BBCA31B9C")]
			[DebuggerHidden]
			public <MoveToTargetX>d__15(int <>1__state)
			{
			}

			// Token: 0x06009B34 RID: 39732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009B34")]
			[Address(RVA = "0x2231BD0", Offset = "0x2231BD0", VA = "0x7BBCA31BD0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06009B35 RID: 39733 RVA: 0x00028C80 File Offset: 0x00026E80
			[Token(Token = "0x6009B35")]
			[Address(RVA = "0x2231BD4", Offset = "0x2231BD4", VA = "0x7BBCA31BD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06009B36 RID: 39734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A56")]
			private object Current
			{
				[Token(Token = "0x6009B36")]
				[Address(RVA = "0x2231DF8", Offset = "0x2231DF8", VA = "0x7BBCA31DF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06009B37 RID: 39735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009B37")]
			[Address(RVA = "0x2231E00", Offset = "0x2231E00", VA = "0x7BBCA31E00", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06009B38 RID: 39736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A57")]
			private object Current
			{
				[Token(Token = "0x6009B38")]
				[Address(RVA = "0x2231E68", Offset = "0x2231E68", VA = "0x7BBCA31E68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A1A4 RID: 41380
			[Token(Token = "0x400A1A4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A1A5 RID: 41381
			[Token(Token = "0x400A1A5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400A1A6 RID: 41382
			[Token(Token = "0x400A1A6")]
			[FieldOffset(Offset = "0x20")]
			public UIWeaponSkinUpgraderPropertyItemController <>4__this;

			// Token: 0x0400A1A7 RID: 41383
			[Token(Token = "0x400A1A7")]
			[FieldOffset(Offset = "0x28")]
			public float targetX;

			// Token: 0x0400A1A8 RID: 41384
			[Token(Token = "0x400A1A8")]
			[FieldOffset(Offset = "0x2C")]
			private Vector3 <pos>5__2;

			// Token: 0x0400A1A9 RID: 41385
			[Token(Token = "0x400A1A9")]
			[FieldOffset(Offset = "0x38")]
			private float <xDelta>5__3;
		}
	}
}
