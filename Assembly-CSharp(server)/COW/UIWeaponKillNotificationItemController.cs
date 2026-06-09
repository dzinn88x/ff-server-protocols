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
	// Token: 0x02001C52 RID: 7250
	[Token(Token = "0x2001C52")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB844", Offset = "0x10FB844")]
	internal class UIWeaponKillNotificationItemController : UIBaseController
	{
		// Token: 0x06009DB1 RID: 40369 RVA: 0x00029430 File Offset: 0x00027630
		[Token(Token = "0x6009DB1")]
		[Address(RVA = "0x1688D24", Offset = "0x1688D24", VA = "0x7BBBE88D24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB2")]
		[Address(RVA = "0x1688D74", Offset = "0x1688D74", VA = "0x7BBBE88D74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009DB3 RID: 40371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB3")]
		[Address(RVA = "0x1688DE8", Offset = "0x1688DE8", VA = "0x7BBBE88DE8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB4")]
		[Address(RVA = "0x1688DF0", Offset = "0x1688DF0", VA = "0x7BBBE88DF0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x00029448 File Offset: 0x00027648
		[Token(Token = "0x6009DB5")]
		[Address(RVA = "0x1688E98", Offset = "0x1688E98", VA = "0x7BBBE88E98")]
		public bool IsActive(float gameTime)
		{
			return default(bool);
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB6")]
		[Address(RVA = "0x1688F14", Offset = "0x1688F14", VA = "0x7BBBE88F14")]
		public void SetActive(bool v)
		{
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB7")]
		[Address(RVA = "0x1688F98", Offset = "0x1688F98", VA = "0x7BBBE88F98")]
		public void SetKillInfo(float gameTime, PendingNotification notification)
		{
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009DB8")]
		[Address(RVA = "0x1689C94", Offset = "0x1689C94", VA = "0x7BBBE89C94")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1145398", Offset = "0x1145398")]
		private IEnumerator AllignCenter()
		{
			return null;
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB9")]
		[Address(RVA = "0x1689D34", Offset = "0x1689D34", VA = "0x7BBBE89D34")]
		public void ShowPreviewNotification(uint itemId, bool ignorePending = false)
		{
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DBA")]
		[Address(RVA = "0x168A004", Offset = "0x168A004", VA = "0x7BBBE8A004")]
		public void SetTweenStart(Vector3 pos)
		{
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DBB")]
		[Address(RVA = "0x168A060", Offset = "0x168A060", VA = "0x7BBBE8A060")]
		public void ResetNotification()
		{
		}

		// Token: 0x06009DBC RID: 40380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DBC")]
		[Address(RVA = "0x1689BE0", Offset = "0x1689BE0", VA = "0x7BBBE89BE0")]
		private void SetQualityBGBySkinId(uint itemId)
		{
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DBD")]
		[Address(RVA = "0x168A12C", Offset = "0x168A12C", VA = "0x7BBBE8A12C")]
		private void SetQualityBG(int quality)
		{
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DBE")]
		[Address(RVA = "0x1689AEC", Offset = "0x1689AEC", VA = "0x7BBBE89AEC")]
		private void ShowSkinEffect(uint itemId, {QAb\u0082~u killerId, bool ignoreKillId = false)
		{
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DBF")]
		[Address(RVA = "0x168A4B4", Offset = "0x168A4B4", VA = "0x7BBBE8A4B4")]
		private void ShowSkinEffectGo(ResourceID resId)
		{
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x00029460 File Offset: 0x00027660
		[Token(Token = "0x6009DC0")]
		[Address(RVA = "0x168A258", Offset = "0x168A258", VA = "0x7BBBE8A258")]
		public bool ShowHandWeaponAnnounceEffect({QAb\u0082~u killerId)
		{
			return default(bool);
		}

		// Token: 0x06009DC1 RID: 40385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DC1")]
		[Address(RVA = "0x168A9D4", Offset = "0x168A9D4", VA = "0x7BBBE8A9D4")]
		public UIWeaponKillNotificationItemController()
		{
		}

		// Token: 0x06009DC2 RID: 40386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DC2")]
		[Address(RVA = "0x168AA3C", Offset = "0x168AA3C", VA = "0x7BBBE8AA3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11453FC", Offset = "0x11453FC")]
		private void <ShowPreviewNotification>b__13_0()
		{
		}

		// Token: 0x0400A3F0 RID: 41968
		[Token(Token = "0x400A3F0")]
		[FieldOffset(Offset = "0x58")]
		private UIWeaponKillNotificationItemView m_View;

		// Token: 0x0400A3F1 RID: 41969
		[Token(Token = "0x400A3F1")]
		[FieldOffset(Offset = "0x60")]
		private bool m_Pending;

		// Token: 0x0400A3F2 RID: 41970
		[Token(Token = "0x400A3F2")]
		[FieldOffset(Offset = "0x64")]
		private uint m_DelayCallID;

		// Token: 0x0400A3F3 RID: 41971
		[Token(Token = "0x400A3F3")]
		[FieldOffset(Offset = "0x68")]
		private Timer m_ShowupTimer;

		// Token: 0x0400A3F4 RID: 41972
		[Token(Token = "0x400A3F4")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<ResourceID, GameObject> m_GoEffects;

		// Token: 0x02001C53 RID: 7251
		[Token(Token = "0x2001C53")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB87C", Offset = "0x10FB87C")]
		private sealed class <AllignCenter>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06009DC3 RID: 40387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DC3")]
			[Address(RVA = "0x1689D08", Offset = "0x1689D08", VA = "0x7BBBE89D08")]
			[DebuggerHidden]
			public <AllignCenter>d__12(int <>1__state)
			{
			}

			// Token: 0x06009DC4 RID: 40388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DC4")]
			[Address(RVA = "0x168AA6C", Offset = "0x168AA6C", VA = "0x7BBBE8AA6C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06009DC5 RID: 40389 RVA: 0x00029478 File Offset: 0x00027678
			[Token(Token = "0x6009DC5")]
			[Address(RVA = "0x168AA70", Offset = "0x168AA70", VA = "0x7BBBE8AA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06009DC6 RID: 40390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A67")]
			private object Current
			{
				[Token(Token = "0x6009DC6")]
				[Address(RVA = "0x168ABEC", Offset = "0x168ABEC", VA = "0x7BBBE8ABEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06009DC7 RID: 40391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009DC7")]
			[Address(RVA = "0x168ABF4", Offset = "0x168ABF4", VA = "0x7BBBE8ABF4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06009DC8 RID: 40392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A68")]
			private object Current
			{
				[Token(Token = "0x6009DC8")]
				[Address(RVA = "0x168AC5C", Offset = "0x168AC5C", VA = "0x7BBBE8AC5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400A3F5 RID: 41973
			[Token(Token = "0x400A3F5")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400A3F6 RID: 41974
			[Token(Token = "0x400A3F6")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400A3F7 RID: 41975
			[Token(Token = "0x400A3F7")]
			[FieldOffset(Offset = "0x20")]
			public UIWeaponKillNotificationItemController <>4__this;
		}
	}
}
