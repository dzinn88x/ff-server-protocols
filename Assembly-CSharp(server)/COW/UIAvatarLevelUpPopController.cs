using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016AB RID: 5803
	[Token(Token = "0x20016AB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0924", Offset = "0x10F0924")]
	public class UIAvatarLevelUpPopController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060069D2 RID: 27090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D2")]
		[Address(RVA = "0x1B2664C", Offset = "0x1B2664C", VA = "0x7BBC32664C", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		[Token(Token = "0x60069D3")]
		[Address(RVA = "0x1B26694", Offset = "0x1B26694", VA = "0x7BBC326694")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D4")]
		[Address(RVA = "0x1B266E4", Offset = "0x1B266E4", VA = "0x7BBC3266E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D5")]
		[Address(RVA = "0x1B26A4C", Offset = "0x1B26A4C", VA = "0x7BBC326A4C")]
		private void OnDebrisClick()
		{
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D6")]
		[Address(RVA = "0x1B26B98", Offset = "0x1B26B98", VA = "0x7BBC326B98")]
		private void OnUnDeBrisClick()
		{
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D7")]
		[Address(RVA = "0x1B26CC8", Offset = "0x1B26CC8", VA = "0x7BBC326CC8")]
		private void OnLevelClick()
		{
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D8")]
		[Address(RVA = "0x1B27060", Offset = "0x1B27060", VA = "0x7BBC327060")]
		private void OntipsCLick()
		{
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D9")]
		[Address(RVA = "0x1B27314", Offset = "0x1B27314", VA = "0x7BBC327314", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DA")]
		[Address(RVA = "0x1B2744C", Offset = "0x1B2744C", VA = "0x7BBC32744C")]
		private void PlayAnimOneShotEvt(string voice_resourceid)
		{
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DB")]
		[Address(RVA = "0x1B275D0", Offset = "0x1B275D0", VA = "0x7BBC3275D0")]
		private void OnUpdateInfo(params object[] data)
		{
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DC")]
		[Address(RVA = "0x1B27920", Offset = "0x1B27920", VA = "0x7BBC327920")]
		private void PlayMaxLevelVfx()
		{
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DD")]
		[Address(RVA = "0x1B29114", Offset = "0x1B29114", VA = "0x7BBC329114")]
		private void StartPlayAnimationText(int oldnum, int nownum)
		{
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069DE")]
		[Address(RVA = "0x1B291F8", Offset = "0x1B291F8", VA = "0x7BBC3291F8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1140CE0", Offset = "0x1140CE0")]
		private IEnumerator PlayTextAnimation(int oldnum, int newnum, int delta)
		{
			return null;
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DF")]
		[Address(RVA = "0x1B292F4", Offset = "0x1B292F4", VA = "0x7BBC3292F4", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E0")]
		[Address(RVA = "0x1B2937C", Offset = "0x1B2937C", VA = "0x7BBC32937C")]
		private void RefreshOwnCount()
		{
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		[Token(Token = "0x60069E1")]
		[Address(RVA = "0x1B29480", Offset = "0x1B29480", VA = "0x7BBC329480", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E2")]
		[Address(RVA = "0x1B27924", Offset = "0x1B27924", VA = "0x7BBC327924")]
		public void RefreshData(AvatarSkillData skilldata, bool playanimation = false)
		{
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		[Token(Token = "0x60069E3")]
		[Address(RVA = "0x1B296C0", Offset = "0x1B296C0", VA = "0x7BBC3296C0")]
		private uint GetAvatarDebrisLockCout(uint avatarid, uint level)
		{
			return 0U;
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		[Token(Token = "0x60069E4")]
		[Address(RVA = "0x1B294C4", Offset = "0x1B294C4", VA = "0x7BBC3294C4")]
		private uint GetAvatarIdBySkillId(uint _skillid)
		{
			return 0U;
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0x1B298AC", Offset = "0x1B298AC", VA = "0x7BBC3298AC")]
		public UIAvatarLevelUpPopController()
		{
		}

		// Token: 0x0400868C RID: 34444
		[Token(Token = "0x400868C")]
		[FieldOffset(Offset = "0x98")]
		private UIAvatarLevelUpPopView m_View;

		// Token: 0x0400868D RID: 34445
		[Token(Token = "0x400868D")]
		[FieldOffset(Offset = "0xA0")]
		private UIAvatarSkillSlotController slotctrl;

		// Token: 0x0400868E RID: 34446
		[Token(Token = "0x400868E")]
		[FieldOffset(Offset = "0xA8")]
		private uint MaxSkillLevel;

		// Token: 0x0400868F RID: 34447
		[Token(Token = "0x400868F")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_IsMaxLevel;

		// Token: 0x04008690 RID: 34448
		[Token(Token = "0x4008690")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_CurrentNeedDebrisCout;

		// Token: 0x04008691 RID: 34449
		[Token(Token = "0x4008691")]
		[FieldOffset(Offset = "0xB4")]
		private uint m_CurrentHasDebrisCout;

		// Token: 0x04008692 RID: 34450
		[Token(Token = "0x4008692")]
		[FieldOffset(Offset = "0xB8")]
		private uint buyid;

		// Token: 0x04008693 RID: 34451
		[Token(Token = "0x4008693")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_AvatarId;

		// Token: 0x04008694 RID: 34452
		[Token(Token = "0x4008694")]
		[FieldOffset(Offset = "0xC0")]
		private AvatarSkillData m_SkillData;

		// Token: 0x04008695 RID: 34453
		[Token(Token = "0x4008695")]
		[FieldOffset(Offset = "0xC8")]
		private uint derbisID;

		// Token: 0x04008696 RID: 34454
		[Token(Token = "0x4008696")]
		[FieldOffset(Offset = "0xCC")]
		private Color passive;

		// Token: 0x04008697 RID: 34455
		[Token(Token = "0x4008697")]
		[FieldOffset(Offset = "0xE0")]
		private List<UIAvatarLevelUpItemController> m_LevelUpList;

		// Token: 0x04008698 RID: 34456
		[Token(Token = "0x4008698")]
		[FieldOffset(Offset = "0xE8")]
		private ulong mytime;

		// Token: 0x020016AC RID: 5804
		[Token(Token = "0x20016AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F095C", Offset = "0x10F095C")]
		private sealed class <PlayTextAnimation>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060069E6 RID: 27110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E6")]
			[Address(RVA = "0x1B292C8", Offset = "0x1B292C8", VA = "0x7BBC3292C8")]
			[DebuggerHidden]
			public <PlayTextAnimation>d__25(int <>1__state)
			{
			}

			// Token: 0x060069E7 RID: 27111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E7")]
			[Address(RVA = "0x1B29970", Offset = "0x1B29970", VA = "0x7BBC329970", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060069E8 RID: 27112 RVA: 0x0001E000 File Offset: 0x0001C200
			[Token(Token = "0x60069E8")]
			[Address(RVA = "0x1B29974", Offset = "0x1B29974", VA = "0x7BBC329974", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x060069E9 RID: 27113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000917")]
			private object Current
			{
				[Token(Token = "0x60069E9")]
				[Address(RVA = "0x1B29A6C", Offset = "0x1B29A6C", VA = "0x7BBC329A6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060069EA RID: 27114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069EA")]
			[Address(RVA = "0x1B29A74", Offset = "0x1B29A74", VA = "0x7BBC329A74", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x060069EB RID: 27115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000918")]
			private object Current
			{
				[Token(Token = "0x60069EB")]
				[Address(RVA = "0x1B29ADC", Offset = "0x1B29ADC", VA = "0x7BBC329ADC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008699 RID: 34457
			[Token(Token = "0x4008699")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400869A RID: 34458
			[Token(Token = "0x400869A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400869B RID: 34459
			[Token(Token = "0x400869B")]
			[FieldOffset(Offset = "0x20")]
			public int oldnum;

			// Token: 0x0400869C RID: 34460
			[Token(Token = "0x400869C")]
			[FieldOffset(Offset = "0x24")]
			public int delta;

			// Token: 0x0400869D RID: 34461
			[Token(Token = "0x400869D")]
			[FieldOffset(Offset = "0x28")]
			public int newnum;

			// Token: 0x0400869E RID: 34462
			[Token(Token = "0x400869E")]
			[FieldOffset(Offset = "0x30")]
			public UIAvatarLevelUpPopController <>4__this;

			// Token: 0x0400869F RID: 34463
			[Token(Token = "0x400869F")]
			[FieldOffset(Offset = "0x38")]
			private int <nownum>5__2;
		}
	}
}
