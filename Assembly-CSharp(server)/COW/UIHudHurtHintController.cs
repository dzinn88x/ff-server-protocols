using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018DB RID: 6363
	[Token(Token = "0x20018DB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5044", Offset = "0x10F5044")]
	internal class UIHudHurtHintController : UIBaseController
	{
		// Token: 0x06007EE3 RID: 32483 RVA: 0x00022AE8 File Offset: 0x00020CE8
		[Token(Token = "0x6007EE3")]
		[Address(RVA = "0x197E52C", Offset = "0x197E52C", VA = "0x7BBC17E52C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE4")]
		[Address(RVA = "0x197E57C", Offset = "0x197E57C", VA = "0x7BBC17E57C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE5")]
		[Address(RVA = "0x197E744", Offset = "0x197E744", VA = "0x7BBC17E744", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007EE6 RID: 32486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE6")]
		[Address(RVA = "0x197E844", Offset = "0x197E844", VA = "0x7BBC17E844", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE7")]
		[Address(RVA = "0x197E96C", Offset = "0x197E96C", VA = "0x7BBC17E96C")]
		private void LateUpdate()
		{
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE8")]
		[Address(RVA = "0x197E788", Offset = "0x197E788", VA = "0x7BBC17E788")]
		private void Clear()
		{
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EE9")]
		[Address(RVA = "0x197EF40", Offset = "0x197EF40", VA = "0x7BBC17EF40")]
		private void OnObservePlayer(object[] data)
		{
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEA")]
		[Address(RVA = "0x197EF44", Offset = "0x197EF44", VA = "0x7BBC17EF44")]
		private void OnLocalPlayerBeHit(params object[] data)
		{
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EEB")]
		[Address(RVA = "0x197FB38", Offset = "0x197FB38", VA = "0x7BBC17FB38")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1142D34", Offset = "0x1142D34")]
		private IEnumerator RemoveHurtHint(float delayTime, ResourceID resourceID)
		{
			return null;
		}

		// Token: 0x06007EEC RID: 32492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEC")]
		[Address(RVA = "0x197FC1C", Offset = "0x197FC1C", VA = "0x7BBC17FC1C")]
		private void DequeueHurtHints(ResourceID resourceID)
		{
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EED")]
		[Address(RVA = "0x197EDB0", Offset = "0x197EDB0", VA = "0x7BBC17EDB0")]
		private void ClearAllHurtHints()
		{
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEE")]
		[Address(RVA = "0x197F8C8", Offset = "0x197F8C8", VA = "0x7BBC17F8C8")]
		private void PlayBurningEffect()
		{
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EEF")]
		[Address(RVA = "0x197FE80", Offset = "0x197FE80", VA = "0x7BBC17FE80")]
		public UIHudHurtHintController()
		{
		}

		// Token: 0x0400920B RID: 37387
		[Token(Token = "0x400920B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudHurtHintView m_View;

		// Token: 0x0400920C RID: 37388
		[Token(Token = "0x400920C")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<ResourceID, Queue> m_HurtHintsMap;

		// Token: 0x0400920D RID: 37389
		[Token(Token = "0x400920D")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<GameObject, Player> m_HintsDict;

		// Token: 0x0400920E RID: 37390
		[Token(Token = "0x400920E")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<{QAb\u0082~u, float> m_ShotGunHitPlayers;

		// Token: 0x020018DC RID: 6364
		[Token(Token = "0x20018DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F507C", Offset = "0x10F507C")]
		private sealed class <RemoveHurtHint>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007EF0 RID: 32496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EF0")]
			[Address(RVA = "0x197FBF0", Offset = "0x197FBF0", VA = "0x7BBC17FBF0")]
			[DebuggerHidden]
			public <RemoveHurtHint>d__12(int <>1__state)
			{
			}

			// Token: 0x06007EF1 RID: 32497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EF1")]
			[Address(RVA = "0x197FF40", Offset = "0x197FF40", VA = "0x7BBC17FF40", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007EF2 RID: 32498 RVA: 0x00022B00 File Offset: 0x00020D00
			[Token(Token = "0x6007EF2")]
			[Address(RVA = "0x197FF44", Offset = "0x197FF44", VA = "0x7BBC17FF44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000998")]
			private object Current
			{
				[Token(Token = "0x6007EF3")]
				[Address(RVA = "0x198000C", Offset = "0x198000C", VA = "0x7BBC18000C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007EF4 RID: 32500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EF4")]
			[Address(RVA = "0x1980014", Offset = "0x1980014", VA = "0x7BBC180014", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000999")]
			private object Current
			{
				[Token(Token = "0x6007EF5")]
				[Address(RVA = "0x198007C", Offset = "0x198007C", VA = "0x7BBC18007C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400920F RID: 37391
			[Token(Token = "0x400920F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009210 RID: 37392
			[Token(Token = "0x4009210")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009211 RID: 37393
			[Token(Token = "0x4009211")]
			[FieldOffset(Offset = "0x20")]
			public float delayTime;

			// Token: 0x04009212 RID: 37394
			[Token(Token = "0x4009212")]
			[FieldOffset(Offset = "0x28")]
			public UIHudHurtHintController <>4__this;

			// Token: 0x04009213 RID: 37395
			[Token(Token = "0x4009213")]
			[FieldOffset(Offset = "0x30")]
			public ResourceID resourceID;
		}
	}
}
