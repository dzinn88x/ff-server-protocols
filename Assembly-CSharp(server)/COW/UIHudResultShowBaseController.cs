using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001650 RID: 5712
	[Token(Token = "0x2001650")]
	internal abstract class UIHudResultShowBaseController : UIHudMatchResultBaseShareController
	{
		// Token: 0x0600671F RID: 26399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600671F")]
		[Address(RVA = "0x17F6504", Offset = "0x17F6504", VA = "0x7BBBFF6504")]
		protected void InitResultPosition()
		{
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006720")]
		[Address(RVA = "0x17F6884", Offset = "0x17F6884", VA = "0x7BBBFF6884", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006721")]
		[Address(RVA = "0x17F6A4C", Offset = "0x17F6A4C", VA = "0x7BBBFF6A4C")]
		protected void CreateCamera()
		{
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x0001D688 File Offset: 0x0001B888
		[Token(Token = "0x6006722")]
		[Address(RVA = "0x17F6D54", Offset = "0x17F6D54", VA = "0x7BBBFF6D54")]
		protected ResourceID GetTeamFormatByCount(int player_count, bool use2DBG = false)
		{
			return default(ResourceID);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006723")]
		[Address(RVA = "0x17F6E80", Offset = "0x17F6E80", VA = "0x7BBBFF6E80")]
		protected void CreateAvatarInMatchResult(List<PlayerData> players, bool win)
		{
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006724")]
		[Address(RVA = "0x17F7C4C", Offset = "0x17F7C4C", VA = "0x7BBBFF7C4C")]
		private void UpdateAvatarAnimatorInMatchResult(UIStatedAvatar avatar)
		{
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006725")]
		[Address(RVA = "0x17F7E84", Offset = "0x17F7E84", VA = "0x7BBBFF7E84")]
		protected void CreateAvatarAndCallSign(List<PlayerData> players)
		{
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006726")]
		[Address(RVA = "0x17F7558", Offset = "0x17F7558", VA = "0x7BBBFF7558")]
		protected UIMaleAvatar CreateMaleAvatar(PlayerData playerData, Transform parent, bool isMatchResult = false)
		{
			return null;
		}

		// Token: 0x06006727 RID: 26407
		[Token(Token = "0x6006727")]
		public abstract void CreateProfileCallSign(PlayerData data, int index);

		// Token: 0x06006728 RID: 26408 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
		[Token(Token = "0x6006728")]
		[Address(RVA = "0x17F7BC8", Offset = "0x17F7BC8", VA = "0x7BBBFF7BC8")]
		protected bool IsDoubleWeild(WeaponSkinData data)
		{
			return default(bool);
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006729")]
		[Address(RVA = "0x17ECB04", Offset = "0x17ECB04", VA = "0x7BBBFECB04")]
		protected UIBaseProfileInfoController CreateBaseProfileInfoController(PlayerData data, int index, UIBaseView view, Transform parent, float yOffset = -0.1f)
		{
			return null;
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x0001D6B8 File Offset: 0x0001B8B8
		[Token(Token = "0x600672A")]
		[Address(RVA = "0x17F84B4", Offset = "0x17F84B4", VA = "0x7BBBFF84B4")]
		protected Vector3 ScreenToLocalPosition(UIBaseView view, Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672B")]
		[Address(RVA = "0x17F85D8", Offset = "0x17F85D8", VA = "0x7BBBFF85D8", Slot = "37")]
		protected virtual void PlayAvatarsEmote()
		{
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672C")]
		[Address(RVA = "0x17F8900", Offset = "0x17F8900", VA = "0x7BBBFF8900")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11409B4", Offset = "0x11409B4")]
		private IEnumerator CoPlayEmotionAnimationd(uint id)
		{
			return null;
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600672D")]
		[Address(RVA = "0x17F8998", Offset = "0x17F8998", VA = "0x7BBBFF8998")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140A18", Offset = "0x1140A18")]
		private IEnumerator StartUIUnlock()
		{
			return null;
		}

		// Token: 0x0600672E RID: 26414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672E")]
		[Address(RVA = "0x17EC3AC", Offset = "0x17EC3AC", VA = "0x7BBBFEC3AC")]
		protected void CreateResultShowWindow()
		{
		}

		// Token: 0x0600672F RID: 26415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672F")]
		[Address(RVA = "0x17F8A64", Offset = "0x17F8A64", VA = "0x7BBBFF8A64")]
		protected void CreateResultShow2DWindow(bool spectator, out Camera bgCamera, out Camera avatarCamera)
		{
		}

		// Token: 0x06006730 RID: 26416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006730")]
		[Address(RVA = "0x17F9014", Offset = "0x17F9014", VA = "0x7BBBFF9014", Slot = "38")]
		protected virtual List<PlayerData> CreateResultData()
		{
			return null;
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006731")]
		[Address(RVA = "0x17F9040", Offset = "0x17F9040", VA = "0x7BBBFF9040", Slot = "39")]
		protected virtual void InitResultShowWindow()
		{
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006732")]
		[Address(RVA = "0x17ECFA4", Offset = "0x17ECFA4", VA = "0x7BBBFECFA4")]
		protected UIHudResultShowBaseController()
		{
		}

		// Token: 0x04008491 RID: 33937
		[Token(Token = "0x4008491")]
		[FieldOffset(Offset = "0xA0")]
		protected GameObject ResultShowInfo;

		// Token: 0x04008492 RID: 33938
		[Token(Token = "0x4008492")]
		[FieldOffset(Offset = "0xA8")]
		protected Transform result_Show_pos;

		// Token: 0x04008493 RID: 33939
		[Token(Token = "0x4008493")]
		[FieldOffset(Offset = "0xB0")]
		protected Camera camera_ob_result;

		// Token: 0x04008494 RID: 33940
		[Token(Token = "0x4008494")]
		[FieldOffset(Offset = "0xB8")]
		protected List<UIMaleAvatar> avatarList;

		// Token: 0x04008495 RID: 33941
		[Token(Token = "0x4008495")]
		[FieldOffset(Offset = "0xC0")]
		protected int EMOTE_WAIT_TIME;

		// Token: 0x04008496 RID: 33942
		[Token(Token = "0x4008496")]
		[FieldOffset(Offset = "0xC4")]
		protected int CLOSE_UI_UNLOCK_TIME;

		// Token: 0x04008497 RID: 33943
		[Token(Token = "0x4008497")]
		[FieldOffset(Offset = "0xC8")]
		protected int scene_id_test;

		// Token: 0x04008498 RID: 33944
		[Token(Token = "0x4008498")]
		[FieldOffset(Offset = "0xCC")]
		protected bool uiCloseLock;

		// Token: 0x04008499 RID: 33945
		[Token(Token = "0x4008499")]
		[FieldOffset(Offset = "0xD0")]
		private GameObject m_TeamFormatGO;

		// Token: 0x02001651 RID: 5713
		[Token(Token = "0x2001651")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFF9C", Offset = "0x10EFF9C")]
		private sealed class <CoPlayEmotionAnimationd>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006733 RID: 26419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006733")]
			[Address(RVA = "0x17F8A0C", Offset = "0x17F8A0C", VA = "0x7BBBFF8A0C")]
			[DebuggerHidden]
			public <CoPlayEmotionAnimationd>d__22(int <>1__state)
			{
			}

			// Token: 0x06006734 RID: 26420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006734")]
			[Address(RVA = "0x17F9044", Offset = "0x17F9044", VA = "0x7BBBFF9044", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006735 RID: 26421 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
			[Token(Token = "0x6006735")]
			[Address(RVA = "0x17F9048", Offset = "0x17F9048", VA = "0x7BBBFF9048", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06006736 RID: 26422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700090B")]
			private object Current
			{
				[Token(Token = "0x6006736")]
				[Address(RVA = "0x17F9250", Offset = "0x17F9250", VA = "0x7BBBFF9250", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006737 RID: 26423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006737")]
			[Address(RVA = "0x17F9258", Offset = "0x17F9258", VA = "0x7BBBFF9258", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06006738 RID: 26424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700090C")]
			private object Current
			{
				[Token(Token = "0x6006738")]
				[Address(RVA = "0x17F92C0", Offset = "0x17F92C0", VA = "0x7BBBFF92C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400849A RID: 33946
			[Token(Token = "0x400849A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400849B RID: 33947
			[Token(Token = "0x400849B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400849C RID: 33948
			[Token(Token = "0x400849C")]
			[FieldOffset(Offset = "0x20")]
			public UIHudResultShowBaseController <>4__this;

			// Token: 0x0400849D RID: 33949
			[Token(Token = "0x400849D")]
			[FieldOffset(Offset = "0x28")]
			public uint id;
		}

		// Token: 0x02001652 RID: 5714
		[Token(Token = "0x2001652")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFFAC", Offset = "0x10EFFAC")]
		private sealed class <StartUIUnlock>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006739 RID: 26425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006739")]
			[Address(RVA = "0x17F8A38", Offset = "0x17F8A38", VA = "0x7BBBFF8A38")]
			[DebuggerHidden]
			public <StartUIUnlock>d__23(int <>1__state)
			{
			}

			// Token: 0x0600673A RID: 26426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600673A")]
			[Address(RVA = "0x17F92C8", Offset = "0x17F92C8", VA = "0x7BBBFF92C8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600673B RID: 26427 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
			[Token(Token = "0x600673B")]
			[Address(RVA = "0x17F92CC", Offset = "0x17F92CC", VA = "0x7BBBFF92CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x0600673C RID: 26428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700090D")]
			private object Current
			{
				[Token(Token = "0x600673C")]
				[Address(RVA = "0x17F9394", Offset = "0x17F9394", VA = "0x7BBBFF9394", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600673D RID: 26429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600673D")]
			[Address(RVA = "0x17F939C", Offset = "0x17F939C", VA = "0x7BBBFF939C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x0600673E RID: 26430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700090E")]
			private object Current
			{
				[Token(Token = "0x600673E")]
				[Address(RVA = "0x17F9404", Offset = "0x17F9404", VA = "0x7BBBFF9404", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400849E RID: 33950
			[Token(Token = "0x400849E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400849F RID: 33951
			[Token(Token = "0x400849F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040084A0 RID: 33952
			[Token(Token = "0x40084A0")]
			[FieldOffset(Offset = "0x20")]
			public UIHudResultShowBaseController <>4__this;
		}
	}
}
