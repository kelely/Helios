// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy.Dto
{
    /// <summary>
    /// �⻧ע�᷵�ؽ������
    /// </summary>
    public class RegisterTenantOutput
    {
        /// <summary>
        /// �⻧Id
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// �⻧��ʶ����(��������)
        /// </summary>
        public string TenancyName { get; set; }

        /// <summary>
        /// �⻧����(������)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ����Ա�û���
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// ����Ա�����ʼ���ַ
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// �⻧�Ƿ��Ѿ�����
        /// </summary>
        public bool IsTenantActive { get; set; }

        /// <summary>
        /// �û��Ƿ��Ѿ��������
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// �Ƿ���Ҫ�ʼ�ȷ��
        /// </summary>
        public bool IsEmailConfirmationRequired { get; set; }
    }
}