﻿namespace Smartstore.Core.Checkout.Payment
{
    /// <summary>
    /// Represents a capture payment result.
    /// </summary>
    public partial class CapturePaymentResult : PaymentResult
    {
        /// <summary>
        /// Gets or sets the capture transaction identifier.
        /// Usually this comes from a payment gateway.
        /// </summary>
        public string CaptureTransactionId { get; set; }

        /// <summary>
        /// Gets or sets a short result info about the payment capture.
        /// </summary>
        public string CaptureTransactionResult { get; set; }

        /// <summary>
        /// Gets or sets a payment status after processing.
        /// </summary>
        public PaymentStatus NewPaymentStatus { get; set; } = PaymentStatus.Pending;
    }
}
