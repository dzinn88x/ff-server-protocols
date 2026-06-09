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
	// Token: 0x02001421 RID: 5153
	[Token(Token = "0x2001421")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC7D8", Offset = "0x10EC7D8")]
	public class UIHUDArmsRaceKillPointsController : UIBaseController
	{
		// Token: 0x06005506 RID: 21766 RVA: 0x000195F0 File Offset: 0x000177F0
		[Token(Token = "0x6005506")]
		[Address(RVA = "0x16B0E68", Offset = "0x16B0E68", VA = "0x7BBBEB0E68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005507")]
		[Address(RVA = "0x16B0EB8", Offset = "0x16B0EB8", VA = "0x7BBBEB0EB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005508")]
		[Address(RVA = "0x16B111C", Offset = "0x16B111C", VA = "0x7BBBEB111C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005509")]
		[Address(RVA = "0x16B1290", Offset = "0x16B1290", VA = "0x7BBBEB1290")]
		private void OnGameArmsListCome(params object[] param)
		{
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550A")]
		[Address(RVA = "0x16B1584", Offset = "0x16B1584", VA = "0x7BBBEB1584")]
		private void OnArmKillPointsCome(params object[] param)
		{
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550B")]
		[Address(RVA = "0x16B1624", Offset = "0x16B1624", VA = "0x7BBBEB1624")]
		private void PlayPointsUpAnim()
		{
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550C")]
		[Address(RVA = "0x16B16B8", Offset = "0x16B16B8", VA = "0x7BBBEB16B8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E83C", Offset = "0x113E83C")]
		private IEnumerator IEPointsUpAnim()
		{
			return null;
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00019608 File Offset: 0x00017808
		[Token(Token = "0x600550D")]
		[Address(RVA = "0x16B1758", Offset = "0x16B1758", VA = "0x7BBBEB1758")]
		private int GetShowLevelByPoint(int point)
		{
			return 0;
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00019620 File Offset: 0x00017820
		[Token(Token = "0x600550E")]
		[Address(RVA = "0x16B1830", Offset = "0x16B1830", VA = "0x7BBBEB1830")]
		private int GetRealLevelByPoint(int point)
		{
			return 0;
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550F")]
		[Address(RVA = "0x16B1304", Offset = "0x16B1304", VA = "0x7BBBEB1304")]
		private void PrepareShowLevelEmptyPoint(int showLevel)
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005510")]
		[Address(RVA = "0x16B1930", Offset = "0x16B1930", VA = "0x7BBBEB1930")]
		private void LightingKillPoint(int index)
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005511")]
		[Address(RVA = "0x16B19B8", Offset = "0x16B19B8", VA = "0x7BBBEB19B8")]
		private void OnKillLeader(params object[] param)
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005512")]
		[Address(RVA = "0x16B1BA8", Offset = "0x16B1BA8", VA = "0x7BBBEB1BA8")]
		public UIHUDArmsRaceKillPointsController()
		{
		}

		// Token: 0x04007A2A RID: 31274
		[Token(Token = "0x4007A2A")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDArmsRaceKillPointsView m_View;

		// Token: 0x04007A2B RID: 31275
		[Token(Token = "0x4007A2B")]
		[FieldOffset(Offset = "0x60")]
		private int m_KillPoints;

		// Token: 0x04007A2C RID: 31276
		[Token(Token = "0x4007A2C")]
		[FieldOffset(Offset = "0x64")]
		private int m_CurShowArmLevel;

		// Token: 0x04007A2D RID: 31277
		[Token(Token = "0x4007A2D")]
		[FieldOffset(Offset = "0x68")]
		private int m_CurShowAnimPoint;

		// Token: 0x04007A2E RID: 31278
		[Token(Token = "0x4007A2E")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine m_AnimHandle;

		// Token: 0x04007A2F RID: 31279
		[Token(Token = "0x4007A2F")]
		[FieldOffset(Offset = "0x78")]
		private List<YmQ\u0082E\u007FN> m_CachArmsList;

		// Token: 0x04007A30 RID: 31280
		[Token(Token = "0x4007A30")]
		[FieldOffset(Offset = "0x80")]
		private List<UIHUDArmsRacePointItem> m_PointItems;

		// Token: 0x04007A31 RID: 31281
		[Token(Token = "0x4007A31")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsPlayingPointUpAnim;

		// Token: 0x02001422 RID: 5154
		[Token(Token = "0x2001422")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC810", Offset = "0x10EC810")]
		private sealed class <IEPointsUpAnim>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005513 RID: 21779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005513")]
			[Address(RVA = "0x16B172C", Offset = "0x16B172C", VA = "0x7BBBEB172C")]
			[DebuggerHidden]
			public <IEPointsUpAnim>d__14(int <>1__state)
			{
			}

			// Token: 0x06005514 RID: 21780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005514")]
			[Address(RVA = "0x16B1C18", Offset = "0x16B1C18", VA = "0x7BBBEB1C18", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005515 RID: 21781 RVA: 0x00019638 File Offset: 0x00017838
			[Token(Token = "0x6005515")]
			[Address(RVA = "0x16B1C1C", Offset = "0x16B1C1C", VA = "0x7BBBEB1C1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06005516 RID: 21782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700087A")]
			private object Current
			{
				[Token(Token = "0x6005516")]
				[Address(RVA = "0x16B1E68", Offset = "0x16B1E68", VA = "0x7BBBEB1E68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005517 RID: 21783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005517")]
			[Address(RVA = "0x16B1E70", Offset = "0x16B1E70", VA = "0x7BBBEB1E70", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06005518 RID: 21784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700087B")]
			private object Current
			{
				[Token(Token = "0x6005518")]
				[Address(RVA = "0x16B1ED8", Offset = "0x16B1ED8", VA = "0x7BBBEB1ED8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007A32 RID: 31282
			[Token(Token = "0x4007A32")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007A33 RID: 31283
			[Token(Token = "0x4007A33")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007A34 RID: 31284
			[Token(Token = "0x4007A34")]
			[FieldOffset(Offset = "0x20")]
			public UIHUDArmsRaceKillPointsController <>4__this;
		}
	}
}
