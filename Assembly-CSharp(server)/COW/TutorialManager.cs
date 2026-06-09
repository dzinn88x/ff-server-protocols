using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200168F RID: 5775
	[Token(Token = "0x200168F")]
	public class TutorialManager : SingletonModule<TutorialManager>
	{
		// Token: 0x060068E1 RID: 26849 RVA: 0x0001DB50 File Offset: 0x0001BD50
		[Token(Token = "0x60068E1")]
		[Address(RVA = "0x1A32700", Offset = "0x1A32700", VA = "0x7BBC232700")]
		public TutorialEventEnum CurrentTutorialType()
		{
			return TutorialEventEnum.None;
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E2")]
		[Address(RVA = "0x1A32708", Offset = "0x1A32708", VA = "0x7BBC232708", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E3")]
		[Address(RVA = "0x1A32B74", Offset = "0x1A32B74", VA = "0x7BBC232B74", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E4")]
		[Address(RVA = "0x1A328D8", Offset = "0x1A328D8", VA = "0x7BBC2328D8")]
		private void InitTutorialSettings()
		{
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E5")]
		[Address(RVA = "0x1A32CB0", Offset = "0x1A32CB0", VA = "0x7BBC232CB0")]
		public void Stop(TutorialEventEnum type = TutorialEventEnum.TutorialEventMax)
		{
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E6")]
		[Address(RVA = "0x1A331DC", Offset = "0x1A331DC", VA = "0x7BBC2331DC")]
		private void StopLast()
		{
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[Token(Token = "0x60068E7")]
		[Address(RVA = "0x1A32D78", Offset = "0x1A32D78", VA = "0x7BBC232D78")]
		private bool CheckAndShowNextTuto(TutorialEventEnum type)
		{
			return default(bool);
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068E8")]
		[Address(RVA = "0x1A338E4", Offset = "0x1A338E4", VA = "0x7BBC2338E4")]
		public void SetReinstallEffective()
		{
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x0001DB80 File Offset: 0x0001BD80
		[Token(Token = "0x60068E9")]
		[Address(RVA = "0x1A33C00", Offset = "0x1A33C00", VA = "0x7BBC233C00")]
		public bool IsFinished(TutorialEventEnum eventType)
		{
			return default(bool);
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x0001DB98 File Offset: 0x0001BD98
		[Token(Token = "0x60068EA")]
		[Address(RVA = "0x1A33CF0", Offset = "0x1A33CF0", VA = "0x7BBC233CF0")]
		public bool IsNew(TutorialEventEnum eventType)
		{
			return default(bool);
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EB")]
		[Address(RVA = "0x1A33D94", Offset = "0x1A33D94", VA = "0x7BBC233D94")]
		public void SetTutorialFinish(TutorialEventEnum eventType)
		{
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EC")]
		[Address(RVA = "0x1A33FE4", Offset = "0x1A33FE4", VA = "0x7BBC233FE4")]
		public void SetAllTutorialFinish()
		{
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0x1A34188", Offset = "0x1A34188", VA = "0x7BBC234188")]
		public void ResetAllTutorial()
		{
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		[Token(Token = "0x60068EE")]
		[Address(RVA = "0x1A33204", Offset = "0x1A33204", VA = "0x7BBC233204")]
		public bool ShowTutorial(TutorialEventEnum eventType, [Optional] Transform showTrans)
		{
			return default(bool);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068EF")]
		[Address(RVA = "0x1A3432C", Offset = "0x1A3432C", VA = "0x7BBC23432C")]
		public void SetTutorialParams(TutorialEventEnum eventType, string param)
		{
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F0")]
		[Address(RVA = "0x1A343CC", Offset = "0x1A343CC", VA = "0x7BBC2343CC")]
		public void RefreshTutorialPosition(Transform showTrans)
		{
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F1")]
		[Address(RVA = "0x1A344A4", Offset = "0x1A344A4", VA = "0x7BBC2344A4")]
		public void RefreshTutorialWholePosition(Transform showTrans)
		{
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
		[Token(Token = "0x60068F2")]
		[Address(RVA = "0x1A33540", Offset = "0x1A33540", VA = "0x7BBC233540")]
		public bool CanShowTutorial(TutorialEventEnum eventType)
		{
			return default(bool);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0x1A3457C", Offset = "0x1A3457C", VA = "0x7BBC23457C")]
		public void StopClimb()
		{
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0x1A34584", Offset = "0x1A34584", VA = "0x7BBC234584")]
		public float GetDuration(TutorialEventEnum eventType)
		{
			return 0f;
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F5")]
		[Address(RVA = "0x1A34640", Offset = "0x1A34640", VA = "0x7BBC234640")]
		public TutorialManager()
		{
		}

		// Token: 0x040085FC RID: 34300
		[Token(Token = "0x40085FC")]
		private const string TutorialKey = "TutorialStep";

		// Token: 0x040085FD RID: 34301
		[Token(Token = "0x40085FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<long> m_TutorialStepFlag;

		// Token: 0x040085FE RID: 34302
		[Token(Token = "0x40085FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<long> m_TutorialStepFlag_ThisLauncher;

		// Token: 0x040085FF RID: 34303
		[Token(Token = "0x40085FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int stepFlagCount;

		// Token: 0x04008600 RID: 34304
		[Token(Token = "0x4008600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, TutorialSetting> m_TutSettings;

		// Token: 0x04008601 RID: 34305
		[Token(Token = "0x4008601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UITutorialIndicatorController m_TutController;

		// Token: 0x04008602 RID: 34306
		[Token(Token = "0x4008602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TutorialVariant variant;

		// Token: 0x04008603 RID: 34307
		[Token(Token = "0x4008603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool reinstallEffective;

		// Token: 0x04008604 RID: 34308
		[Token(Token = "0x4008604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private TutorialEventEnum m_CurTutorial;

		// Token: 0x04008605 RID: 34309
		[Token(Token = "0x4008605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private uint delayCallId;
	}
}
