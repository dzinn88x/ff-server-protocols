using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001086 RID: 4230
	[Token(Token = "0x2001086")]
	internal class ArenaNPCPlayer : MonoBehaviour
	{
		// Token: 0x060040E6 RID: 16614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x1550830", Offset = "0x1550830", VA = "0x7BBBD50830")]
		public void CreatePlayer(EPPlayerInfo playerInfo, ResourceID animID)
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x1550CF8", Offset = "0x1550CF8", VA = "0x7BBBD50CF8")]
		private void RerenderAfterUMAChanged(UMAData data)
		{
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x1550C84", Offset = "0x1550C84", VA = "0x7BBBD50C84")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113C4B4", Offset = "0x113C4B4")]
		protected IEnumerator UpdateTopPlayerAvatar()
		{
			return null;
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x1550E20", Offset = "0x1550E20", VA = "0x7BBBD50E20")]
		public ArenaNPCPlayer()
		{
		}

		// Token: 0x0400505B RID: 20571
		[Token(Token = "0x400505B")]
		[FieldOffset(Offset = "0x18")]
		private AvatarManager m_AvatarManager;

		// Token: 0x0400505C RID: 20572
		[Token(Token = "0x400505C")]
		[FieldOffset(Offset = "0x20")]
		private EPPlayerInfo m_PlayerInfo;

		// Token: 0x0400505D RID: 20573
		[Token(Token = "0x400505D")]
		[FieldOffset(Offset = "0x28")]
		private ResourceID m_ResourceID;

		// Token: 0x02001087 RID: 4231
		[Token(Token = "0x2001087")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EABC4", Offset = "0x10EABC4")]
		private sealed class <UpdateTopPlayerAvatar>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060040EA RID: 16618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040EA")]
			[Address(RVA = "0x1550DF4", Offset = "0x1550DF4", VA = "0x7BBBD50DF4")]
			[DebuggerHidden]
			public <UpdateTopPlayerAvatar>d__5(int <>1__state)
			{
			}

			// Token: 0x060040EB RID: 16619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040EB")]
			[Address(RVA = "0x1550E98", Offset = "0x1550E98", VA = "0x7BBBD50E98", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060040EC RID: 16620 RVA: 0x00013F68 File Offset: 0x00012168
			[Token(Token = "0x60040EC")]
			[Address(RVA = "0x1550E9C", Offset = "0x1550E9C", VA = "0x7BBBD50E9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x060040ED RID: 16621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000767")]
			private object Current
			{
				[Token(Token = "0x60040ED")]
				[Address(RVA = "0x1550FE4", Offset = "0x1550FE4", VA = "0x7BBBD50FE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060040EE RID: 16622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040EE")]
			[Address(RVA = "0x1550FEC", Offset = "0x1550FEC", VA = "0x7BBBD50FEC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x060040EF RID: 16623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000768")]
			private object Current
			{
				[Token(Token = "0x60040EF")]
				[Address(RVA = "0x1551054", Offset = "0x1551054", VA = "0x7BBBD51054", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400505E RID: 20574
			[Token(Token = "0x400505E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400505F RID: 20575
			[Token(Token = "0x400505F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005060 RID: 20576
			[Token(Token = "0x4005060")]
			[FieldOffset(Offset = "0x20")]
			public ArenaNPCPlayer <>4__this;
		}
	}
}
